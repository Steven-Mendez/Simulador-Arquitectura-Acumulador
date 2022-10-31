using SimulatorAcc.GrammaticalAnalysis;
using SimulatorAcc.InstructionAnalysis;
using SimulatorAcc.LexicalAnalysis;
using SimulatorAcc.Memory;
using SimulatorAcc.SymbolTable;
using System.Text.RegularExpressions;

namespace SimulatorAcc
{
    public partial class Accumulator
    {
        public Accumulator(string sourceFile)
        {
            SourceFile = sourceFile;
            LeanFileContent = new List<string>();
            Errors = new List<Error>();
            RulesTable = new List<Rule>();
            SymbolTable = new List<Symbol>();
            Code = new List<Instruction>();
            KeyWords = new Dictionary<string, Token>();
            ParseRules = new Dictionary<string, RuleTypes>();
            CreateKeyWords();
            CreateParsingRules();
        }

        public int AssembleSourceFile()
        {
            InputFileContent = File.ReadAllLines(SourceFile);

            int lineNumber = 0;
            int address = 0;
            int instructionNumber = 0;
            bool isBranchInstruction;
            RuleTypes ruleId;
            string ParseKey;
            ParseErrors = 0;
            LexErrors = 0;
            Result = true;

            foreach (string line in InputFileContent)
            {
                lineNumber++;

                // Clean the line
                string leanLine = Regex.Replace(Regex.Replace(line.Trim(charsToTrim), "[ \t]+", " "), ",", " ,");

                // Exceptional Cases
                if (leanLine == "")
                    continue;

                if (leanLine[0] == ChrComment)
                    continue;

                LeanFileContent.Add(leanLine);
                Rule lineParsing = new(lineNumber);
                ParseKey = "";
                ruleId = RuleTypes.None;
                isBranchInstruction = false;

                // Split The Line In Words
                string[] words = leanLine.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // Identify Tokens
                for (int i = 0; i < words.Length; i++)
                {
                    string thisWord = words[i].ToUpper();

                    // If it's a KeyWord
                    if (KeyWords.TryGetValue(thisWord, out Token? thisKeyWord))
                    {
                        // Add the token to the parse key
                        ParseKey += thisKeyWord.Key;

                        // Add Token
                        lineParsing.Tokens.Add(new Token(thisKeyWord));

                        // Check If it's a Branch Instruction
                        if (isBranchInstruction == false)
                            isBranchInstruction = (thisKeyWord.Key == "J" || thisKeyWord.Key == "B");
                        continue;
                    }

                    Token thisToken = Tokenizer(thisWord, lineNumber, isBranchInstruction);
                    ParseKey += thisToken.Key;
                    lineParsing.Tokens.Add(thisToken);
                }

                // If can't identify the parse rule, then error
                if (!ParseRules.TryGetValue(ParseKey, out ruleId))
                {
                    lineParsing.ParseKey = ParseKey;
                    lineParsing.RuleType = ruleId;
                    lineParsing.IsOk = false;
                    RulesTable.Add(lineParsing);
                    Errors.Add(new Error(lineNumber, "InvalidRule", ParseKey, $"Line {lineNumber}: Rule {ParseKey} doesn't exist"));
                    ParseErrors++;
                    continue;
                }

                // Complete the Constructor
                lineParsing.ContentText = leanLine;
                lineParsing.ParseKey = ParseKey;
                lineParsing.RuleType = ruleId;
                lineParsing.IsOk = true;
                RulesTable.Add(lineParsing);

                // Identify Instruction or Data (Process the Construct)
                switch (ruleId)
                {
                    case RuleTypes.NotInitStatement:
                        SymbolTable.Add(new Symbol(TokenTypes.Variable, lineParsing.Tokens[1].Name, address++, 0));
                        break;

                    case RuleTypes.Statement:
                        SymbolTable.Add(new Symbol(TokenTypes.Variable, lineParsing.Tokens[1].Name, address++, lineParsing.Tokens[2].Id));
                        break;

                    case RuleTypes.Label:
                        SymbolTable.Add(new Symbol(TokenTypes.Label, lineParsing.Tokens[0].Name[1..], instructionNumber, instructionNumber));
                        break;

                    case RuleTypes.NumberOperation:
                    case RuleTypes.VariableOperation:
                        Code.Add(new Instruction(
                            adddress: instructionNumber++,
                            line: lineNumber,
                            text: leanLine,
                            instructionType: lineParsing.RuleType,
                            operationType: lineParsing.Tokens[0].Type,
                            operation: lineParsing.Tokens[0].Name,
                            operationCode: lineParsing.Tokens[0].Id,
                            operandType: lineParsing.Tokens[1].Type,
                            operand: lineParsing.Tokens[1].Name,
                            operandCode: lineParsing.Tokens[1].Id,
                            tokens: lineParsing.Tokens
                            ));
                        break;

                    case RuleTypes.LoadVariable:
                    case RuleTypes.LoadNumber:
                        // Verify If The Second Operand is Variable or E
                        if (lineParsing.Tokens[1].Type == TokenTypes.Variable)
                        {
                            // Search the Variable in the SymbolTable
                            Symbol? v = SymbolTable.FirstOrDefault(d => d.Name == lineParsing.Tokens[1].Name);
                            if (v != null)
                            {
                                lineParsing.Tokens[1].Id = v.Address;
                            }
                            else if (ruleId != RuleTypes.LoadNumber)
                            {
                                // Error
                                Errors.Add(new Error(lineNumber, "Undeclared_Variable", ParseKey, $"Line {lineNumber}: Variable {lineParsing.Tokens[1].Name} was not declared"));
                                ParseErrors++;
                                Result = false;
                            }
                        }
                        Code.Add(new Instruction(
                            adddress: instructionNumber++,
                            line: lineNumber,
                            text: leanLine,
                            instructionType: lineParsing.RuleType,
                            operationType: lineParsing.Tokens[0].Type,
                            operation: lineParsing.Tokens[0].Name,
                            operationCode: lineParsing.Tokens[0].Id,
                            operandType: lineParsing.Tokens[1].Type,
                            operand: lineParsing.Tokens[1].Name,
                            operandCode: lineParsing.Tokens[1].Id,
                            tokens: lineParsing.Tokens
                            ));
                        break;

                    case RuleTypes.Store:
                        // Verify If The Second Operand is Variable
                        if (lineParsing.Tokens[1].Type == TokenTypes.Variable)
                        {
                            // Search the Variable in the SymbolTable
                            Symbol? v = SymbolTable.FirstOrDefault(d => d.Name == lineParsing.Tokens[1].Name);
                            if (v != null)
                            {
                                lineParsing.Tokens[1].Id = v.Address;
                            }
                            else
                            {
                                // Error
                                Errors.Add(new Error(lineNumber, "Undeclared_Variable", ParseKey, $"Line {lineNumber}: Variable {lineParsing.Tokens[1].Name} was not declared"));
                                ParseErrors++;
                                Result = false;
                            }
                        }
                        Code.Add(new Instruction(
                            adddress: instructionNumber++,
                            line: lineNumber,
                            text: leanLine,
                            instructionType: lineParsing.RuleType,
                            operationType: lineParsing.Tokens[0].Type,
                            operation: lineParsing.Tokens[0].Name,
                            operationCode: lineParsing.Tokens[0].Id,
                            operandType: lineParsing.Tokens[1].Type,
                            operand: lineParsing.Tokens[1].Name,
                            operandCode: lineParsing.Tokens[1].Id,
                            tokens: lineParsing.Tokens
                            ));
                        break;

                    case RuleTypes.UnconditionalJump:
                    case RuleTypes.conditionalJump:
                        // Verify If The Second Operand is Label
                        if (lineParsing.Tokens[1].Type == TokenTypes.Label)
                        {
                            // Search the Label in the SymbolTable
                            Symbol? v = SymbolTable.FirstOrDefault(d => d.Name == lineParsing.Tokens[1].Name);
                            if (v != null)
                            {
                                lineParsing.Tokens[1].Id = v.Address;
                            }
                            else
                            {
                                // Error
                                Errors.Add(new Error(lineNumber, "Undeclared_Label", ParseKey, $"Line {lineNumber}: Label {lineParsing.Tokens[1].Name} was not declared"));
                                ParseErrors++;
                                Result = false;
                            }
                        }
                        Code.Add(new Instruction(
                            adddress: instructionNumber++,
                            line: lineNumber,
                            text: leanLine,
                            instructionType: lineParsing.RuleType,
                            operationType: lineParsing.Tokens[0].Type,
                            operation: lineParsing.Tokens[0].Name,
                            operationCode: lineParsing.Tokens[0].Id,
                            operandType: lineParsing.Tokens[1].Type,
                            operand: lineParsing.Tokens[1].Name,
                            operandCode: lineParsing.Tokens[1].Id,
                            tokens: lineParsing.Tokens
                            ));
                        break;

                    case RuleTypes.Halt:
                    case RuleTypes.Nop:
                        Code.Add(new Instruction(
                            adddress: instructionNumber++,
                            line: lineNumber,
                            text: leanLine,
                            instructionType: lineParsing.RuleType,
                            operationType: lineParsing.Tokens[0].Type,
                            operation: lineParsing.Tokens[0].Name,
                            operationCode: lineParsing.Tokens[0].Id,
                            operand: "",
                            operandType: TokenTypes.Void,
                            operandCode: 0,
                            tokens: lineParsing.Tokens
                            ));
                        break;

                    case RuleTypes.Code:
                        break;

                    case RuleTypes.Data:
                        break;

                    default:
                        break;
                }
            }
            return ParseErrors + LexErrors;
        }

        public Token Tokenizer(string thisWord, int lineNumber, bool isBranchInstruction)
        {
            int kind;
            char m, n = thisWord[0];
            Token thisToken;

            // If the current caracter is a Digit
            if (n >= '0' && n <= '9')
            {
                kind = 1; // ???

                // Verify if all word is a digit
                for (int j = 1; j < thisWord.Length; j++)
                {
                    m = thisWord[j];

                    // If the current char is not a digit break the loop
                    if (!(m >= '0' && m <= '9'))
                    {
                        kind = 0; // ?
                        break;
                    }
                }

                // if is a type one 
                if (kind == 1)
                {
                    // E = Entero
                    thisToken = new Token(id: int.Parse(thisWord), type: TokenTypes.Number, name: thisWord, key: "E");
                    return thisToken;
                }
            }

            // If the current caracter is a Label
            if (n == ChrTag)
            {
                // T = Tag
                thisToken = new Token(id: lineNumber, type: TokenTypes.Label, name: thisWord, key: "T");
                return thisToken;
            }

            // If the current caracter is a Variable
            if (n >= 'A' && n <= 'Z' || n == '_')
            {
                kind = 3; //?

                // Verify if all the word is a variable
                for (int j = 0; j < thisWord.Length; j++)
                {
                    m = thisWord[j];

                    // If the current char is invalid break the loop
                    if (!(m >= '0' && m <= '9' || m >= 'A' && m <= 'Z' || m == '_'))
                    {
                        kind = 0;
                        break;
                    }
                }

                // If is a variable, then what type of variable?
                if (kind == 3)
                {
                    if (isBranchInstruction)
                    {
                        thisToken = new Token(id: 0, type: TokenTypes.Label, name: thisWord, key: "T");
                    }
                    else
                    {
                        thisToken = new Token(id: 0, type: TokenTypes.Variable, name: thisWord, key: "V");
                    }
                    return thisToken;
                }
            }

            // Otherwise, return a error token
            thisToken = new Token(id: -1, type: TokenTypes.LexError, name: thisWord, key: "X");
            Errors.Add(new Error(lineNumber, "InvalidToken", thisWord, $"Line {lineNumber}: Token {thisWord} is invalid."));
            LexErrors++;
            return thisToken;
        }

        public int LoadProgram()
        {
            int i = 0;
            PC = 0;
            MemoryCells = new List<MemoryCell>();

            // Load Variables
            foreach (var symbol in SymbolTable)
            {
                if (symbol.SymbolType != TokenTypes.Variable)
                    continue;

                MemoryCells[i].T = 'V';
                MemoryCells[i].Value = symbol.InitValue.ToString();
                MemoryCells[i].Text = symbol.Name;
                i++;
            }

            // Load Code
            PC = i;
            foreach (var instruction in Code)
            {
                MemoryCells[i].T = 'I';
                MemoryCells[i].Value = instruction.DecimalFormat.ToString();
                MemoryCells[i].Text = instruction.Text;
                i++;
            }
            return PC;
        }
    }
}