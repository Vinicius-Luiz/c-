using System.Linq;

namespace api_linq.Filters;

public class LinqOrder
{
    public static void OrdenarPorArtista(List<Musica> musicas)
    {
        var artistasOrdenads = musicas
            .OrderBy(m => m.Artista)
            .Select(m => m.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine("Artistas ordenados por artista:");
        foreach (var artista in artistasOrdenads)
        {
            Console.WriteLine($"> {artista}");
        }
    }
}