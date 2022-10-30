using SimulatorAcc.GrammaticalAnalysis;
using SimulatorAcc.LexicalAnalysis;

namespace SimulatorAcc.InstructionAnalysis
{
    /// <summary>
    /// Unidad de programa. Contiene información de una instrucción detectada a partir del análisis gramatical del código fuente.
    /// </summary>
    public class Instruction
    {
        public int Adddress { get; set; }
        public int Line { get; set; }
        public string Text { get; set; }
        public RuleTypes InstructionType { get; set; }
        public string BinaryFormat { get; set; }
        //public char[] BinaryData;
        public string HexFormat { get; set; }
        public uint DecimalFormat { get; set; }
        public string Operation { get; set; }
        public TokenTypes OperationType { get; set; }
        public int OperationCode { get; set; }
        public string Operand { get; set; }
        public TokenTypes OperandType { get; set; }
        public int OperandCode { get; set; }
        public List<Token> Tokens { get; set; }

        public Instruction(int adddress, int line, string text, RuleTypes instructionType,
            string operation, string operand, TokenTypes operationType, int operationCode,
            TokenTypes operandType, int operandCode, List<Token> tokens)
        {
            Adddress = adddress;
            Line = line;
            Text = text;
            InstructionType = instructionType;
            OperationType = operationType;
            Operation = operation;
            OperationCode = operationCode;
            OperandType = operandType;
            Operand = operand;
            OperandCode = operandCode;
            Tokens = tokens;
            DecimalFormat = (uint)(OperationCode << 25);
            switch (InstructionType)
            {
                case RuleTypes.Store:
                case RuleTypes.conditionalJump:
                case RuleTypes.NumberOperation:
                case RuleTypes.VariableOperation:
                    DecimalFormat += (uint)(OperandCode << 20);
                    break;
                case RuleTypes.UnconditionalJump:
                    DecimalFormat += (uint)(OperandCode);
                    break;
                case RuleTypes.Halt:
                case RuleTypes.Nop:
                    break;
            }
            HexFormat = Convert.ToString(DecimalFormat, toBase: 16);
            BinaryFormat = Convert.ToString(DecimalFormat, toBase: 2).PadLeft(32, '0');
        }
    }
}