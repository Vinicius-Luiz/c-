namespace classe_generica;

public class ListContas<T>
{
    public List<T>? Contas { get; set; }
    private readonly int Tamanho;

    public ListContas(int tamanho)
    {
        Contas = new();
        Tamanho = tamanho;
    }

    public void Inserir(T conta)
    {
        if (Contas!.Count == Tamanho)
        {
            throw new Exception("Lista de Contas bancárias cheia");
        }
        Contas.Add(conta);
    }

    public void Remover(T conta)
    {
        Contas!.Remove(conta);
    }

}