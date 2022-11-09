namespace SimulatorAcc.Memory
{
    /// <summary>
    /// Unidad de memoria. Representa una localidad de memoria que se utilizará en la interfaz de usuario.
    /// </summary>
    public class MemoryCell
    {
        public string? Address { get; set; }
        public string? Text { get; set; }
        public string? Value { get; set; }
        public string? Type { get; set; }
    }
}