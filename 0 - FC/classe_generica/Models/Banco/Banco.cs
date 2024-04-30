namespace classe_generica;
public class Banco
{
    public string? Nome { get; set; }
    public string? Cnpj { get; set; }
    public ListContas<Conta> Contas { get; set; }

    public Banco(string cnpj, int tamanho)
    {
        Cnpj = cnpj;
        Contas = new ListContas<Conta>(tamanho);
    }
    public override string ToString() => $"| {Nome} - {Cnpj} |";

    public void Inserir(Conta conta)
    {
        Contas.Inserir(conta);
    }

    public void Remover(Conta conta)
    {
        Contas.Remover(conta);
    }

    public Conta Buscar(string cpf)
    {
        return Contas.Contas!.Find(conta => conta.Cpf == cpf)!;
    }

    public void MostrarContas()
    {
        Console.WriteLine($"Banco: {Nome}");
        Contas.Contas!.ForEach(conta => Console.WriteLine(conta));
        Console.WriteLine("\n");
    }

}