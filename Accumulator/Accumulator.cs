using Accumulator.GrammaticalAnalysis;
using Accumulator.InstructionAnalysis;
using Accumulator.LexicalAnalysis;
using Accumulator.SymbolTable;
using System;

namespace Accumulator;

public class Accumulator
{
    private const char ChrTag = ':';

    private string _sourceFile { get; }
    public List<Error> Errors { get; set; } = new List<Error>();
    public int LexErrors { get; set; }
    public List<string> LeanFileContent { get; set; }
    public List<Construct> ProgramConstructs { get; set; }
    public List<Symbol> SymbolTable { get; set; }
    public List<Instruction> Code { get; set; }

    public Accumulator(string sourceFile)
    {
        _sourceFile = sourceFile;

        // Inicializando estructuras de datos auxiliares
        LeanFileContent = new List<string>();
        Errors = new List<Error>();
        ProgramConstructs = new List<Construct>();
        SymbolTable = new List<Symbol>();
        Code = new List<Instruction>();

        
    }

    public int AssembleSourceFile()
    {
        char[] charsToTrim = { ' ', '\t', 'n' };

        // Directives
        Dictionary<string, Token> KeyWords = new Dictionary<string, Token>();
        Dictionary<string, RuleTypes> ParseRules = new Dictionary<string, RuleTypes>();

        KeyWords.Add(".DATA", new Token(TokenTypes.DirectivaDato, ".DATA", 100, "D"));
        KeyWords.Add(".CODE", new Token(TokenTypes.DirectivaCódigo, ".CODE", 200, "C"));

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
        ParseRules.Add("AV", RuleTypes.Declaración_NI); // Not Init Statement
        ParseRules.Add("OR,R,R", RuleTypes.Instrucción_3R); // R-instruction
        ParseRules.Add("OR,R,E", RuleTypes.Instrucción_3I); //  E-instruction
        ParseRules.Add("LR,V", RuleTypes.Instrucción_L); // Load V
        ParseRules.Add("LR,E", RuleTypes.Instrucción_LI); // Load E
        ParseRules.Add("SV,R", RuleTypes.Instrucción_S); // Store
        ParseRules.Add("JT", RuleTypes.Instrucción_J); // Unconditional Branch
        ParseRules.Add("BR,T", RuleTypes.Instrucción_B); // Conditional Branch
        ParseRules.Add("N", RuleTypes.Instrucción_N); // NOP
        ParseRules.Add("H", RuleTypes.Instrucción_H); // HALT

        return 0;
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
}
