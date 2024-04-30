namespace classe_generica;

public class Funcionario : IComparable<Funcionario>
{
    public int Matricula { get; set; }
    public string? Nome { get; set; }
    public decimal Salario { get; set; }

    public Funcionario(int Matricula)
    {
        this.Matricula = Matricula;
    }
    public override string ToString() => $"| {Matricula} - {Nome} - {Salario} |";

    public int CompareTo(Funcionario? other)
    {
        if (other is null)
        {
            return 1;
        }
        else
        {
            return Matricula.CompareTo(other.Matricula);
        }
    }

}
