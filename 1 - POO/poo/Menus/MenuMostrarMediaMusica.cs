namespace poo;
internal class MenuMostrarMediaMusica : Menu
{
    override public void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("MEDIA DE MUSICAS");

        Console.Write("Nome da banda:\n> ");
        string nomeBanda = Console.ReadLine()!;

        Console.Write("Nome do Album:\n> ");
        string nomeAlbum = Console.ReadLine()!;

        Console.Write("Nome da Musica:\n> ");
        string nomeMusica = Console.ReadLine()!;

        int index = bandas.FindIndex(banda => banda.Nome == nomeBanda);
        if (index >= 0)
        {
            int albumIndex = bandas[index].Albuns.FindIndex(album => album.Nome == nomeAlbum);
            if (albumIndex >= 0)
            {
                int musicaIndex = bandas[index].Albuns[albumIndex].Musicas.FindIndex(musica => musica.Nome == nomeMusica);
                if (musicaIndex >= 0)
                {
                    Console.WriteLine($"Media de {nomeMusica}: {bandas[index].Albuns[albumIndex].Musicas[musicaIndex].Media}");
                }
                else
                {
                    Console.WriteLine("Musica inexistente");
                }
            }
            else
            {
                Console.WriteLine("Album inexistente");
            }

        }
    }
}