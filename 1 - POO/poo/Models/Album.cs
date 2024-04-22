namespace poo;

internal class Album : IAvaliavel
{
    public List<Musica> Musicas = new();
    List<Avaliacao> Avaliacoes = new();
    public string? Nome { get; }
    public double DuracaoTotal => Musicas.Sum(m => m.Duracao);
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

    public Album(string nome)
    {
        Nome = nome;
    }

    public void AddMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void FichaTecnica()
    {
        foreach (Musica musica in Musicas)
        {
            musica.FichaTecnica();
        }
        Console.WriteLine($"Duracao total: {DuracaoTotal}min");
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
