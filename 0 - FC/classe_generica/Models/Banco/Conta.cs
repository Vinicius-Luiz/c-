namespace classe_generica;

public class Conta
{
    public string? Cpf { get; }
    public string? Nome { get; set; }
    public decimal Saldo { get; set; }

    public Conta(string cpf)
    {
        Cpf = cpf;
    }
    public override string ToString() => $"| {Cpf} - {Nome} - {Saldo} |";

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        Saldo -= valor;
    }

}
