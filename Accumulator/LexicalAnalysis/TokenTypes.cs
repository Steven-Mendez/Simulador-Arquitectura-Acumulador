namespace Accumulator.LexicalAnalysis
{
    /// <summary>
    /// Contiene información del tipo token detectado durante el proceso de análisis léxico.
    /// </summary>
    public enum TokenTypes
    {
        DirectivaDato,
        DirectivaCódigo,
        Declaración,
        Coma,
        Etiqueta,
        Operación,
        Traslado,
        Salto,
        Fin,
        NOP,
        Variable,
        Registro,
        Entero,
        ErrorLéxico,
        Vacío
    }
}