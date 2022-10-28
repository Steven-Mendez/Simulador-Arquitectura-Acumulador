using SimulatorAcc.GrammaticalAnalysis;
using SimulatorAcc.InstructionAnalysis;
using SimulatorAcc.LexicalAnalysis;
using SimulatorAcc.Memory;
using SimulatorAcc.SymbolTable;
using System.Text.RegularExpressions;

namespace SimulatorAcc
{
    public class Accumulator
    {
        private const char ChrTag = ':';
        public const char ChrComment = ';';

        private string sourceFile { get; }
        public List<Error> Errors { get; set; } = new List<Error>();
        public int LexErrors { get; set; }
        public List<string> LeanFileContent { get; set; }
        public List<Construct> ProgramConstructs { get; set; }
        public List<Symbol> SymbolTable { get; set; }
        public List<Instruction> Code { get; set; }
        public string[] inputFileContent { get; set; }
        public bool result { get; set; }
        public int ParseErrors { get; set; }

        public int PC;

        public List<MemoryCell> MemoryCells { get; set; }

        public Accumulator(string sourceFile)
        {
            this.sourceFile = sourceFile;

            LeanFileContent = new List<string>();
            Errors = new List<Error>();
            ProgramConstructs = new List<Construct>();
            SymbolTable = new List<Symbol>();
            Code = new List<Instruction>();
        }

        public int AssembleSourceFile()
        {
            char[] charsToTrim = { ' ', '\t', '\n' };

            // Directives
            Dictionary<string, Token> KeyWords = new Dictionary<string, Token>();
            Dictionary<string, RuleTypes> ParseRules = new Dictionary<string, RuleTypes>();

            KeyWords.Add(".DATA", new Token(TokenTypes.DirectivaDato, ".DATA", 100, "D"));
            KeyWords.Add(".CODE", new Token(TokenTypes.DirectivaCódigo, ".CODE", 200, "C"));

            // Definitions
            KeyWords.Add("DW", new Token(TokenTypes.Declaración, "DW", 300, "A"));

            // Arithmetic operations
            KeyWords.Add("ADD", new Token(TokenTypes.Operación, "ADD", 0, "O"));
            KeyWords.Add("SUB", new Token(TokenTypes.Operación, "SUB", 1, "O"));
            KeyWords.Add("DIV", new Token(TokenTypes.Operación, "DIV", 2, "O"));
            KeyWords.Add("MUL", new Token(TokenTypes.Operación, "MUL", 3, "O"));

            // Logic Operation
            KeyWords.Add("CMP", new Token(TokenTypes.Operación, "CMP", 4, "O"));

            // Transfer Operations
            KeyWords.Add("LOAD", new Token(TokenTypes.Traslado, "LOAD", 8, "L"));
            KeyWords.Add("STORE", new Token(TokenTypes.Traslado, "STORE", 9, "S"));

            // Jump Operations
            KeyWords.Add("BR", new Token(TokenTypes.Salto, "BR", 32, "J"));
            KeyWords.Add("BRZ", new Token(TokenTypes.Salto, "BRZ", 33, "B"));
            KeyWords.Add("BNZ", new Token(TokenTypes.Salto, "BNZ", 34, "B"));
            KeyWords.Add("BGT", new Token(TokenTypes.Salto, "BGT", 35, "B"));
            KeyWords.Add("BLT", new Token(TokenTypes.Salto, "BLT", 36, "B"));

            // No Operation
            KeyWords.Add("NOP", new Token(TokenTypes.NOP, "NOP", 126, "N"));

            // Halt Operation
            KeyWords.Add("HLT", new Token(TokenTypes.Fin, "HLT", 127, "H"));

            // Registers
            for (int i = 0; i <= 31; i++)
            {
                KeyWords.Add("R" + i.ToString(), new Token(TokenTypes.Registro, "R" + i.ToString(), i, "R"));
            }

            // Separator
            KeyWords.Add(",", new Token(TokenTypes.Coma, ",", 1, ","));

            // Parsing Rules
            ParseRules.Add("D", RuleTypes.DirectivaDato); // Data Directive
            ParseRules.Add("C", RuleTypes.DirectivaCódigo); // Code Directive
            ParseRules.Add("T", RuleTypes.Etiqueta); // Labels
            ParseRules.Add("AVE", RuleTypes.Declaración); // Statement
            ParseRules.Add("AV", RuleTypes.Declaración_NI); // Not Initialized Statement
            ParseRules.Add("OR,R,R", RuleTypes.Instrucción_3R); // R-instruction
            ParseRules.Add("OR,R,E", RuleTypes.Instrucción_3I); //  E-instruction
            ParseRules.Add("LR,V", RuleTypes.Instrucción_L); // Load V
            ParseRules.Add("LR,E", RuleTypes.Instrucción_LI); // Load E
            ParseRules.Add("SV,R", RuleTypes.Instrucción_S); // Store
            ParseRules.Add("JT", RuleTypes.Instrucción_J); // Unconditional Branch
            ParseRules.Add("BR,T", RuleTypes.Instrucción_B); // Conditional Branch
            ParseRules.Add("N", RuleTypes.Instrucción_N); // NOP
            ParseRules.Add("H", RuleTypes.Instrucción_H); // HALT

            inputFileContent = File.ReadAllLines(sourceFile);

            int lineNumber = 0;
            int address = 0;
            int instructionNumber = 0;
            bool isBranchInstruction;
            RuleTypes ruleId;
            string ParseKey;
            ParseErrors = 0;
            LexErrors = 0;
            result = true;

            foreach (string line in inputFileContent)
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
                Construct lineParsing = new Construct(lineNumber);
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

                    Token thisToken = Lexer(thisWord, lineNumber, isBranchInstruction);
                    ParseKey += thisToken.Key;
                    lineParsing.Tokens.Add(thisToken);
                }

                // If can't identify the parse rule, then error
                if (!ParseRules.TryGetValue(ParseKey, out ruleId))
                {
                    lineParsing.ParseKey = ParseKey;
                    lineParsing.RuleType = ruleId;
                    lineParsing.IsOk = false;
                    ProgramConstructs.Add(lineParsing);
                    Errors.Add(new Error(lineNumber, "InvalidRule", ParseKey, $"Line {lineNumber}: Rule {ParseKey} doesn't exist"));
                    continue;
                }

                // Complete the Constructor
                lineParsing.ContentText = leanLine;
                lineParsing.ParseKey = ParseKey;
                lineParsing.RuleType = ruleId;
                lineParsing.IsOk = true;
                ProgramConstructs.Add(lineParsing);

                // Identify Instruction or Data (Process the Construct)
                switch (ruleId)
                {
                    // Not Initialized Statement
                    case RuleTypes.Declaración_NI:
                        SymbolTable.Add(new Symbol(TokenTypes.Variable, lineParsing.Tokens[1].Name, address++, 0));
                        break;

                    // Statement
                    case RuleTypes.Declaración:
                        SymbolTable.Add(new Symbol(TokenTypes.Variable, lineParsing.Tokens[1].Name, address++, lineParsing.Tokens[2].Id));
                        break;

                    // Label
                    case RuleTypes.Etiqueta:
                        SymbolTable.Add(new Symbol(TokenTypes.Etiqueta, lineParsing.Tokens[0].Name.Substring(1), instructionNumber, instructionNumber));
                        break;

                    //  R3 Instructions. ex: "add r3 , r1 , r2"
                    case RuleTypes.Instrucción_3I:
                    case RuleTypes.Instrucción_3R:
                        Code.Add(new Instruction(
                            dirección: instructionNumber++,
                            línea: lineNumber,
                            instrucción: leanLine,
                            tipo: lineParsing.RuleType,
                            operación: lineParsing.Tokens[0].Name,
                            O1: lineParsing.Tokens[1].Name,
                            O2: lineParsing.Tokens[3].Name,
                            O3: lineParsing.Tokens[5].Name,
                            tipoOp: lineParsing.Tokens[0].Type,
                            IdOp: lineParsing.Tokens[0].Id,
                            tipoO1: lineParsing.Tokens[1].Type,
                            vO1: lineParsing.Tokens[1].Id,
                            tipoO2: lineParsing.Tokens[3].Type,
                            vO2: lineParsing.Tokens[3].Id,
                            tipoO3: lineParsing.Tokens[5].Type,
                            vO3: lineParsing.Tokens[5].Id,
                            tokens: lineParsing.Tokens
                            ));
                        break;

                    // Load Instructions ex: "Load r9 , 3"
                    case RuleTypes.Instrucción_L:
                    case RuleTypes.Instrucción_LI:

                        // Verify If The Second Operand is Variable
                        if (lineParsing.Tokens[3].Type == TokenTypes.Variable)
                        {
                            // Search the Variable in the SymbolTable
                            Symbol? v = SymbolTable.FirstOrDefault(d => d.Name == lineParsing.Tokens[3].Name);
                            if (v != null)
                            {
                                lineParsing.Tokens[3].Id = v.Address;
                            }
                            else if (ruleId != RuleTypes.Instrucción_LI)
                            {
                                // Error
                                Errors.Add(new Error(lineNumber, "Undeclared_Variable", ParseKey, $"Line {lineNumber}: Variable {lineParsing.Tokens[1].Name} was not declared"));
                                ParseErrors++;
                                result = false;
                            }
                        }
                        Code.Add(new Instruction(
                            dirección: instructionNumber++,
                            línea: lineNumber,
                            instrucción: leanLine,
                            tipo: lineParsing.RuleType,
                            operación: lineParsing.Tokens[0].Name,
                            O1: lineParsing.Tokens[1].Name,
                            O2: lineParsing.Tokens[3].Name,
                            O3: "",
                            tipoOp: lineParsing.Tokens[0].Type,
                            IdOp: lineParsing.Tokens[0].Id,
                            tipoO1: lineParsing.Tokens[1].Type,
                            vO1: lineParsing.Tokens[1].Id,
                            tipoO2: lineParsing.Tokens[3].Type,
                            vO2: lineParsing.Tokens[3].Id,
                            tipoO3: TokenTypes.Vacío,
                            vO3: 0,
                            tokens: lineParsing.Tokens
                            ));
                        break;

                    // Store Instruction. Ex: "store a , r4" => R4 <- a
                    case RuleTypes.Instrucción_S:

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
                                result = false;
                            }
                        }
                        Code.Add(new Instruction(
                            dirección: instructionNumber++,
                            línea: lineNumber,
                            instrucción: leanLine,
                            tipo: lineParsing.RuleType,
                            operación: lineParsing.Tokens[0].Name,
                            O1: lineParsing.Tokens[1].Name,
                            O2: lineParsing.Tokens[3].Name,
                            O3: "",
                            tipoOp: lineParsing.Tokens[0].Type,
                            IdOp: lineParsing.Tokens[0].Id,
                            tipoO1: lineParsing.Tokens[3].Type,
                            vO1: lineParsing.Tokens[3].Id,
                            tipoO2: lineParsing.Tokens[1].Type,
                            vO2: lineParsing.Tokens[1].Id,
                            tipoO3: TokenTypes.Vacío,
                            vO3: 0,
                            tokens: lineParsing.Tokens
                            ));
                        break;

                    // Unconditional Jump Instruccions.
                    case RuleTypes.Instrucción_J:

                        // Verify If The Second Operand is Label
                        if (lineParsing.Tokens[1].Type == TokenTypes.Etiqueta)
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
                                result = false;
                            }
                        }
                        Code.Add(new Instruction(
                            dirección: instructionNumber++,
                            línea: lineNumber,
                            instrucción: leanLine,
                            tipo: lineParsing.RuleType,
                            operación: lineParsing.Tokens[0].Name,
                            O1: lineParsing.Tokens[1].Name,
                            O2: "",
                            O3: "",
                            tipoOp: lineParsing.Tokens[0].Type,
                            IdOp: lineParsing.Tokens[0].Id,
                            tipoO1: lineParsing.Tokens[1].Type,
                            vO1: lineParsing.Tokens[1].Id,
                            tipoO2: TokenTypes.Vacío,
                            vO2: 0,
                            tipoO3: TokenTypes.Vacío,
                            vO3: 0,
                            tokens: lineParsing.Tokens));
                        break;

                    // Jump Instruccions. ex: "bnz r9 , ciclo"
                    case RuleTypes.Instrucción_B:

                        // Verify If The Second Operand is Label
                        if (lineParsing.Tokens[3].Type == TokenTypes.Etiqueta)
                        {
                            // Search the Label in the SymbolTable
                            Symbol? v = SymbolTable.FirstOrDefault(d => d.Name == lineParsing.Tokens[3].Name);
                            if (v != null)
                            {
                                lineParsing.Tokens[3].Id = v.Address;
                            }
                            else
                            {
                                // Error
                                Errors.Add(new Error(lineNumber, "Undeclared_Label", ParseKey, $"Line {lineNumber}: Label {lineParsing.Tokens[1].Name} was not declared"));
                                ParseErrors++;
                                result = false;
                            }
                        }
                        Code.Add(new Instruction(
                            dirección: instructionNumber++,
                            línea: lineNumber,
                            instrucción: leanLine,
                            tipo: lineParsing.RuleType,
                            operación: lineParsing.Tokens[0].Name,
                            O1: lineParsing.Tokens[1].Name,
                            O2: lineParsing.Tokens[3].Name,
                            O3: "",
                            tipoOp: lineParsing.Tokens[0].Type,
                            IdOp: lineParsing.Tokens[0].Id,
                            tipoO1: lineParsing.Tokens[1].Type,
                            vO1: lineParsing.Tokens[1].Id,
                            tipoO2: lineParsing.Tokens[3].Type,
                            vO2: lineParsing.Tokens[3].Id,
                            tipoO3: TokenTypes.Vacío,
                            vO3: 0,
                            tokens: lineParsing.Tokens));
                        break;

                    case RuleTypes.Instrucción_H:
                    case RuleTypes.Instrucción_N:
                        Code.Add(new Instruction(
                            dirección: instructionNumber++,
                            línea: lineNumber,
                            instrucción: leanLine,
                            tipo: lineParsing.RuleType,
                            operación: lineParsing.Tokens[0].Name,
                            O1: "",
                            O2: "",
                            O3: "",
                            tipoOp: lineParsing.Tokens[0].Type,
                            IdOp: lineParsing.Tokens[0].Id,
                            tipoO1: TokenTypes.Vacío,
                            vO1: 0,
                            tipoO2: TokenTypes.Vacío,
                            vO2: 0,
                            tipoO3: TokenTypes.Vacío,
                            vO3: 0,
                            tokens: lineParsing.Tokens
                            ));
                        break;

                    case RuleTypes.DirectivaCódigo:
                        break;

                    case RuleTypes.DirectivaDato:
                        break;

                    default:
                        break;
                }
            }

            return (ParseErrors + LexErrors);
        }

        public Token Lexer(string thisWord, int lineNumber, bool isBranchInstruction)
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
                    thisToken = new Token(id: int.Parse(thisWord), type: TokenTypes.Entero, name: thisWord, key: "E");
                    return thisToken;
                }
            }

            // If the current caracter is a Label
            if (n == ChrTag)
            {
                // T = Tag
                thisToken = new Token(id: lineNumber, type: TokenTypes.Etiqueta, name: thisWord, key: "T");
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
                        thisToken = new Token(id: 0, type: TokenTypes.Etiqueta, name: thisWord, key: "T");
                    }
                    else
                    {
                        thisToken = new Token(id: 0, type: TokenTypes.Variable, name: thisWord, key: "V");
                    }
                    return thisToken;
                }
            }

            // Otherwise, return a error token
            thisToken = new Token(id: -1, type: TokenTypes.ErrorLéxico, name: thisWord, key: "X");
            Errors.Add(new Error(lineNumber, "InvalidToken", thisWord, $"Line {lineNumber}: Token {thisWord} is invalid."));
            LexErrors++;
            return thisToken;
        }

        public int LoadProgram()
        {
            int i = 0;
            PC = 0;

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
                MemoryCells[i].Value = instruction.FormatoDecimal.ToString();
                MemoryCells[i].Text = instruction.Instrucción;
                i++;
            }
            return PC;
        }
    }
}