namespace api_linq;

using System.Linq;


public class MusicasFavoritas
{
    public List<Musica> ListaMusicasFavoritas { get; }
    string NomeUsuario { get; }

    public MusicasFavoritas(string nome)
    {
        NomeUsuario = nome;
        ListaMusicasFavoritas = new List<Musica>();
    }

    public void AddMusicaFavorita(Musica musica)
    {
        ListaMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Musicas favoritas de {NomeUsuario}:");
        foreach (Musica musica in ListaMusicasFavoritas)
        {
            musica.ExibirResumo();
            Console.WriteLine("");
        }
    }
}