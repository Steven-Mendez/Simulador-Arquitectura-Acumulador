namespace Accumulator.LexicalAnalysis
{
    /// <summary>
    /// Unidad de análisis léxico. Contiene información de un token detectado durante el proceso de análisis léxico.
    /// </summary>
    public class Token
    {
        public int Id { get; }
        public TokenTypes Type { get; }
        public string Name { get; }
        public string Key { get; }

        public Token(TokenTypes type, string name, int id, string key)
        {
            Id = id;
            Type = type;
            Name = name;
            Key = key;
        }

        public Token(Token keyword)
        {
            Name = keyword.Name;
            Type = keyword.Type;
            Id = keyword.Id;
            Key = keyword.Key;
        }
    }
}
