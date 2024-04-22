namespace poo;

internal class Musica : IAvaliavel
{
    List<Avaliacao> Avaliacoes = new();
    public double Media
    {
        get
        {
            if (Avaliacoes.Count == 0)
            {
                return 0;
            }
            double media = 0;
            foreach (Avaliacao avaliacao in Avaliacoes)
            {
                media += avaliacao.Nota;
            }
            return media / Avaliacoes.Count;
        }
    }
    public string? Nome { get; }
    public Banda? Artista { get; }
    public double Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string? Descricao => $"{Artista} - {Nome}";

    public Musica(string nome, Banda artista, bool disponivel = true)
    {
        Nome = nome;
        Artista = artista;
        Disponivel = disponivel;
    }
    public void FichaTecnica()
    {
        Console.WriteLine($"Descricao {Descricao} | {Duracao}min | {(Disponivel ? "Disponível" : "Indisponível")}");
    }

    public int qtdAvaliacoes()
    {
        return Avaliacoes.Count;
    }

    public void AddAvaliacao(Avaliacao avaliacao)
    {
        Avaliacoes.Add(avaliacao);
    }
}
