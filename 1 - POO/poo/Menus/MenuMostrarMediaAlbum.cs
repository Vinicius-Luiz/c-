namespace poo;

internal class MenuMostrarMediaAlbum : Menu
{
    override public void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("MEDIA DE ALBUMS");

        Console.Write("Nome da banda:\n> ");
        string nomeBanda = Console.ReadLine()!;

        Console.Write("Nome do Album:\n> ");
        string nomeAlbum = Console.ReadLine()!;

        int index = bandas.FindIndex(banda => banda.Nome == nomeBanda);
        if (index >= 0)
        {
            int albumIndex = bandas[index].Albuns.FindIndex(album => album.Nome == nomeAlbum);
            if (albumIndex >= 0)
            {
                Console.WriteLine($"Media de {nomeAlbum}: {bandas[index].Albuns[albumIndex].Media}");
            }
            else
            {
                Console.WriteLine("Album inexistente");
            }
        }
        else
        {
            Console.WriteLine("Banda inexistente");
        }
    }
}
