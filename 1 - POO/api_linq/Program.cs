using api_linq;
using api_linq.Filters;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;

        // musicas[2].ExibirDetalhes();

        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.OrdenarPorArtista(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        // LinqFilter.FiltrarMusicasPorArtista(musicas, "Shakira");

        string nVinicius = "Vinicius";
        MusicasFavoritas musicasFavoritasVinicius = new(nome: nVinicius);

        musicasFavoritasVinicius.AddMusicaFavorita(musicas[2]);
        musicasFavoritasVinicius.AddMusicaFavorita(musicas[14]);
        musicasFavoritasVinicius.AddMusicaFavorita(musicas[5]);
        musicasFavoritasVinicius.AddMusicaFavorita(musicas[87]);
        musicasFavoritasVinicius.AddMusicaFavorita(musicas[8]);

        musicasFavoritasVinicius.ExibirMusicasFavoritas();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
}