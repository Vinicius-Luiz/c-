namespace classeHeranca;

public class Veiculo
{
    private string? MarcaP { get; set; }
    private string? ModeloP { get; set; }
    private int AnoP { get; set; }

    public string? Marca { get { return MarcaP; } set { MarcaP = value; } }
    public string? Modelo { get { return ModeloP; } set { ModeloP = value; } }
    public int Ano { get { return AnoP; } set { AnoP = value; } }

    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public virtual void ExibirDetalhes(){
        Console.WriteLine($"Veiculo: {Marca}, {Modelo}, {Ano}");
    }
}
