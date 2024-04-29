namespace arrays_collections;

// Dentro da classe escreva Exception e escolha a 2a opção
[Serializable]
public class ContaException : Exception
{
    public ContaException() { }
    public ContaException(string message) : base($"Exceção de conta: {message}") { }
    public ContaException(string message, Exception inner) : base($"Exceção de conta (i): {message}", inner) { }
    protected ContaException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}