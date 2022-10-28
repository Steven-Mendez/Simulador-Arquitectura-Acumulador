using Accumulator.LexicalAnalysis;

namespace Accumulator.GrammaticalAnalysis
{
    /// <summary>
    /// Unidad de tabla de símbolos. Contiene información de un literal (nombre de variable o etiqueta) detectado en el código fuente
    /// </summary>
    public class Construct
    {
        public int LineNumber { get; }
        public string ContentText { get; set; } = string.Empty;
        public RuleTypes RuleType { get; set; }
        public string ParseKey { get; set; } = string.Empty;
        public bool IsOk { get; set; }

        public List<Token> Tokens;

        public Construct(int lineNumber)
        {
            LineNumber = lineNumber;
            Tokens = new List<Token>();
        }
    }
}