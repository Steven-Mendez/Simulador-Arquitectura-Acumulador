using Accumulator.LexicalAnalysis;

namespace Accumulator.SymbolTable
{
    /// <summary>
    /// Unidad de tabla de símbolos. Contiene información de un literal (nombre de variable o etiqueta) detectado en el código fuente
    /// </summary>
    public class Symbol
    {
        public TokenTypes SymbolType { get; set; }
        public string Name { get; set; }
        public int Address { get; set; }
        public int InitValue { get; set; }

        public Symbol(TokenTypes symbolType, string name, int address, int initValue)
        {
            SymbolType = symbolType;
            Name = name;
            Address = address;
            InitValue = initValue;
        }
    }
}