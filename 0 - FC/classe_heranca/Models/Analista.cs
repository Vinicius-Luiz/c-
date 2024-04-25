namespace classe_heranca;

public class Analista(string nome, string departamento) : Funcionario(nome, departamento)
{
    public override void Trabalhar()
    {
        Console.WriteLine($"{Nome} está trabalhando como analista no departamento de {Departamento}");
    }
}