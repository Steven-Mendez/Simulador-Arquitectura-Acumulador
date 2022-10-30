using SimulatorAcc.GrammaticalAnalysis;
using SimulatorAcc.LexicalAnalysis;

namespace SimulatorAcc.InstructionAnalysis
{
    /// <summary>
    /// Unidad de programa. Contiene información de una instrucción detectada a partir del análisis gramatical del código fuente.
    /// </summary>
    public class Instruction
    {
        public int Dirección { get; set; }
        public int Línea { get; set; }
        public string Instrucción { get; set; }
        public RuleTypes TipoInstrucción { get; set; }
        public string FormatoBinario { get; set; }

        //public char[] BinaryData;
        public string FormatoHexadecimal { get; set; }
        public uint FormatoDecimal { get; set; }
        public string Operación { get; set; }
        public string Operando1 { get; set; }
        public string Operando2 { get; set; }
        public string Operando3 { get; set; }
        public TokenTypes TipoOperación { get; set; }
        public int IdOperacion { get; set; }
        public TokenTypes TipoOperando1 { get; set; }
        public int IdOperando1 { get; set; }
        public TokenTypes TipoOperando2 { get; set; }
        public int IdOperando2 { get; set; }
        public TokenTypes TipoOperando3 { get; set; }
        public int IdOperando3 { get; set; }

        public List<Token> Tokens { get; set; }

        public Instruction(int dirección, int línea, string instrucción, RuleTypes tipo, string operación, string O1, string O2, string O3,
            TokenTypes tipoOp, int IdOp, TokenTypes tipoO1, int vO1, TokenTypes tipoO2, int vO2, TokenTypes tipoO3, int vO3,
            List<Token> tokens)
        {
            Instrucción = instrucción;
            Dirección = dirección;
            Línea = línea;
            TipoInstrucción = tipo;
            Operación = operación;
            Operando1 = O1;
            Operando2 = O2;
            Operando3 = O3;
            TipoOperación = tipoOp;
            IdOperacion = IdOp;
            TipoOperando1 = tipoO1;
            IdOperando1 = vO1;
            TipoOperando2 = tipoO2;
            IdOperando2 = vO2;
            TipoOperando3 = tipoO3;
            IdOperando3 = vO3;
            Tokens = tokens;

            FormatoDecimal = (uint)(IdOperacion << 25); //Codigo de operación
            switch (TipoInstrucción)
            {
                case RuleTypes.Store:
                case RuleTypes.conditionalJump:
                    // Formato I+R
                    FormatoDecimal += (uint)(IdOperando1 << 20); //Primer Operando R
                    FormatoDecimal += (uint)(IdOperando2);       //Segundo Operando E
                    break;
                case RuleTypes.UnconditionalJump:
                    // Formato I
                    FormatoDecimal += (uint)(IdOperando1);       //Primer Operando E
                    break;
                case RuleTypes.NumberOperation:
                    //Formato R+I
                    FormatoDecimal += (uint)(IdOperando1 << 20); //Primer Operando R
                    FormatoDecimal += (uint)(IdOperando2 << 15); //Segundo Operando R
                    FormatoDecimal += (uint)(IdOperando3);       //Tercer Operando E
                    break;
                case RuleTypes.VariableOperation:
                    //Formato R
                    FormatoDecimal += (uint)(IdOperando1 << 20); //Primer Operando R
                    FormatoDecimal += (uint)(IdOperando2 << 15); //Segundo Operando R
                    FormatoDecimal += (uint)(IdOperando2 << 10); //Tercer Operando R
                    break;
                case RuleTypes.Halt:
                case RuleTypes.Nop:
                    //Formato I sin operando
                    break;
            }
            FormatoHexadecimal = Convert.ToString(FormatoDecimal, toBase: 16);
            FormatoBinario = Convert.ToString(FormatoDecimal, toBase: 2).PadLeft(32, '0');
            //FormatoBinario = string.Join("", BinaryData);
            //FormatoBinario = string.Concat(BinaryData);
            //BinaryData = new[] {    '0', '0', '0', '0', '0', '0', '0', '0', 
            //                        '0', '0', '0', '0', '0', '0', '0', '0', 
            //                        '0', '0', '0', '0', '0', '0', '0', '0',
            //                        '0', '0', '0', '0', '0', '0', '0', '0'};
            //FormatoBinario = new string(BinaryData); 

        }
    }
}