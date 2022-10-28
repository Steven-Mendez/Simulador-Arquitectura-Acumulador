namespace SimulatorAcc.LexicalAnalysis
{
    /// <summary>
    /// Contiene información de un error detectado en el archivo fuente durante el proceso de análisis.
    /// </summary>
    public class Error
    {
        public string Message { get; set; }
        public int lineNumber { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }

        public Error(int lineNumber, string code, string text, string message)
        {
            this.lineNumber = lineNumber;
            Code = code;
            Text = text;
            Message = message;
        }
    }
}