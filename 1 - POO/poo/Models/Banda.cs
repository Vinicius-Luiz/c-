namespace poo;

internal class Banda : IAvaliavel
{
    public List<Album> Albuns = new();
    public List<Avaliacao> Avaliacoes = new();
    public string? Nome { get; }
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
    
    public Banda(string nome)
    {
        Nome = nome; // Inicializa o nome da banda
    }

    public void AddAlbum(Album album)
    {
        Albuns.Add(album);
    }

    public void Discografia()
    {
        foreach (Album album in Albuns)
        {
            Console.WriteLine(album.Nome);
            album.FichaTecnica();
            Console.WriteLine();
        }
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
