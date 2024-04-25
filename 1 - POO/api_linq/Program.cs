using api_linq;
using api_linq.Filters;
using System.Text.Json;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using HttpClient client = new();
        try
        {
            string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

            var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;

            musicas[2].ExibirDetalhes();
            Thread.Sleep(1000);
            Console.Clear();

            LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
            Thread.Sleep(1000);
            Console.Clear();

            LinqOrder.OrdenarPorArtista(musicas);
            Thread.Sleep(1000);
            Console.Clear();

            LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
            Thread.Sleep(1000);
            Console.Clear();


            LinqFilter.FiltrarMusicasPorArtista(musicas, "Shakira");
            Thread.Sleep(1000);
            Console.Clear();

            LinqFilter.FiltrarMusicasPorTonalidade(tonalidade: "C#", musicas: musicas);
            Thread.Sleep(1000);
            Console.Clear();

            string nVinicius = "Vinicius";
            MusicasFavoritas musicasFavoritasVinicius = new(nome: nVinicius);

            musicasFavoritasVinicius.AddMusicaFavorita(musicas[2]);
            musicasFavoritasVinicius.AddMusicaFavorita(musicas[14]);
            musicasFavoritasVinicius.AddMusicaFavorita(musicas[5]);
            musicasFavoritasVinicius.AddMusicaFavorita(musicas[87]);
            musicasFavoritasVinicius.AddMusicaFavorita(musicas[8]);

            musicasFavoritasVinicius.ExibirMusicasFavoritas();

            musicasFavoritasVinicius.GerarArquivoJson();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
}