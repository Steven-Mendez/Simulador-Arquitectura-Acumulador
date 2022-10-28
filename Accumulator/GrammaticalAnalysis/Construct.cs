using SimulatorAcc.LexicalAnalysis;

namespace SimulatorAcc.GrammaticalAnalysis
{
    /// <summary>
    /// Contains information of a Grammatical Rule match for a line of Source Code.
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