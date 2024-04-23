using System.Linq;

namespace api_linq.Filters;

public class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var generos = musicas
            .Select(m => m.Genero)
            .Distinct()
            .ToList();

        Console.WriteLine("Todos os generos musicais:");
        foreach (var genero in generos)
        {
            Console.WriteLine($"> {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistas = musicas
            .Where(m => m.Genero!.Contains(genero))
            .Select(m => m.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine($"Artistas do genero {genero}:");
        foreach (var artista in artistas)
        {
            Console.WriteLine($"> {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        // Utiliza o método Where() para filtrar as músicas com base no artista especificado
        // O operador lambda m => m.Artista!.Equals(artista) é usado para comparar o artista da música com o artista fornecido
        // Retorna um IEnumerable<Musica> com as músicas que correspondem ao critério de filtro
        var artistas = musicas
            .Where(m => m.Artista!.Equals(artista))
            // Utiliza o método Select() para projetar apenas o nome das músicas filtradas
            // Retorna um IEnumerable<string> com os nomes das músicas filtradas
            .Select(m => m.Nome)
            // Converte o resultado em uma lista para facilitar a manipulação posterior
            .ToList();

        Console.WriteLine($"Musicas do artista {artista}:");

        foreach (var musica in artistas)
        {
            Console.WriteLine($"> {musica}");
        }
    }

}