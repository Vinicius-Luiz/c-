namespace classe_heranca;

public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome, string departamento) : base(nome, departamento)
    { }

    public override void Trabalhar()
    {
        Console.WriteLine($"{Nome} está Trabalhando como desenvolvedor no departamento de {Departamento}");
    }
}