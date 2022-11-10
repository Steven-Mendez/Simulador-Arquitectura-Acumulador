namespace SimulatorAcc.LexicalAnalysis
{
    /// <summary>
    /// Contiene información del tipo token detectado durante el proceso de análisis léxico.
    /// </summary>
    public enum TokenTypes
    {
        Data,
        Code,
        Statement,
        Label,
        Operation,
        Transfer,
        Jump,
        End,
        NoOperation,
        Variable,
        Number,
        LexError,
        Void,
        IO
    }
}