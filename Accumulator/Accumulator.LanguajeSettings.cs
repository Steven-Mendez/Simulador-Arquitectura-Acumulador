using SimulatorAcc.GrammaticalAnalysis;
using SimulatorAcc.InstructionAnalysis;
using SimulatorAcc.LexicalAnalysis;
using SimulatorAcc.Memory;
using SimulatorAcc.SymbolTable;

namespace SimulatorAcc
{
    public partial class Accumulator
    {
        // Const
        private const char ChrTag = ':';
        private const char ChrComment = ';';

        // Properties
        private string[] SourceFile { get; }
        public List<Error> Errors { get; set; } = new List<Error>();
        public int LexErrors { get; set; }
        public List<string> LeanFileContent { get; set; }
        public List<Rule> RulesTable { get; set; }
        public List<Symbol> SymbolTable { get; set; }
        public List<Instruction> Code { get; set; }
        public string[]? InputFileContent { get; set; }
        public bool Result { get; set; }
        public int ParseErrors { get; set; }
        public List<MemoryCell>? MemoryCells { get; set; }

        // Variables
        public int PC;
        private readonly char[] charsToTrim = { ' ', '\t', '\n' };
        private readonly Dictionary<string, Token> KeyWords;
        private readonly Dictionary<string, RuleTypes> ParseRules;

        private void CreateKeyWords()
        {
            // Directives
            KeyWords.Add(".DATA", new Token(TokenTypes.Data, ".DATA", 100, "D"));
            KeyWords.Add(".CODE", new Token(TokenTypes.Code, ".CODE", 200, "C"));

            // Statements
            KeyWords.Add("DW", new Token(TokenTypes.Statement, "DW", 300, "A"));

            // Arithmetic Operations
            KeyWords.Add("ADD", new Token(TokenTypes.Operation, "ADD", 0, "O"));
            KeyWords.Add("SUB", new Token(TokenTypes.Operation, "SUB", 1, "O"));
            KeyWords.Add("DIV", new Token(TokenTypes.Operation, "DIV", 2, "O"));
            KeyWords.Add("MUL", new Token(TokenTypes.Operation, "MUL", 3, "O"));

            // Logic Operations
            KeyWords.Add("CMP", new Token(TokenTypes.Operation, "CMP", 4, "O"));

            // Transfer Operations
            KeyWords.Add("LOAD", new Token(TokenTypes.Transfer, "LOAD", 8, "L"));
            KeyWords.Add("STORE", new Token(TokenTypes.Transfer, "STORE", 9, "S"));

            // Jump Operations
            KeyWords.Add("JMP", new Token(TokenTypes.Jump, "JMP", 32, "J"));
            KeyWords.Add("JG", new Token(TokenTypes.Jump, "JG", 33, "B"));
            KeyWords.Add("JGE", new Token(TokenTypes.Jump, "JGE", 34, "B"));
            KeyWords.Add("JL", new Token(TokenTypes.Jump, "JL", 35, "B"));
            KeyWords.Add("JLE", new Token(TokenTypes.Jump, "JLE", 36, "B"));
            KeyWords.Add("JZ", new Token(TokenTypes.Jump, "JZ", 37, "B"));

            // IO Instruction
            KeyWords.Add("IN", new Token(TokenTypes.IO, "IN", 124, "IP"));
            KeyWords.Add("OUT", new Token(TokenTypes.IO, "OUT", 125, "OP"));

            // Others
            KeyWords.Add("NOP", new Token(TokenTypes.NoOperation, "NOP", 126, "N"));
            KeyWords.Add("HLT", new Token(TokenTypes.End, "HLT", 127, "H"));
        }

        private void CreateParsingRules()
        {
            ParseRules.Add("D", RuleTypes.Data);
            ParseRules.Add("C", RuleTypes.Code);
            ParseRules.Add("T", RuleTypes.Label);
            ParseRules.Add("N", RuleTypes.Nop);
            ParseRules.Add("H", RuleTypes.Halt);
            ParseRules.Add("LV", RuleTypes.LoadVariable);
            ParseRules.Add("LE", RuleTypes.LoadNumber);
            ParseRules.Add("OV", RuleTypes.VariableOperation);
            ParseRules.Add("OE", RuleTypes.NumberOperation);
            ParseRules.Add("SV", RuleTypes.Store);
            ParseRules.Add("JT", RuleTypes.UnconditionalJump);
            ParseRules.Add("BT", RuleTypes.conditionalJump);
            ParseRules.Add("OP", RuleTypes.IO);
            ParseRules.Add("IP", RuleTypes.IO);
            ParseRules.Add("AV", RuleTypes.NotInitStatement);
            ParseRules.Add("AVE", RuleTypes.Statement);
        }
    }
}
