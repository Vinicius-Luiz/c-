using System.Text.Json;
using System.Text;

namespace api_linq;

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

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new { nome = NomeUsuario, musicas = ListaMusicasFavoritas });
        string NomeArquivo = $"json\\musicas-favoritas-{NomeUsuario}.json";

        File.WriteAllText(NomeArquivo, json, Encoding.UTF8);

        Console.WriteLine($"Arquivo {NomeArquivo} gerado com sucesso!");
    }
}