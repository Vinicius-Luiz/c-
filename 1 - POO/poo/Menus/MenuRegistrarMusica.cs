namespace poo;

internal class MenuRegistrarMusica : Menu
{
    override public void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("REGISTRAR MUSICAS");

        Console.Write("Nome da banda:\n> ");
        string nomeBanda = Console.ReadLine()!;

        Console.Write("Nome do album:\n> ");
        string nomeAlbum = Console.ReadLine()!;


        int index = bandas.FindIndex(banda => banda.Nome == nomeBanda);
        if (index >= 0)
        {
            int albumIndex = bandas[index].Albuns.FindIndex(album => album.Nome == nomeAlbum);
            if (albumIndex >= 0)
            {
                Console.Write("Nome da música:\n> ");
                string nomeMusica = Console.ReadLine()!;

                Console.Write("Duração da música:\n> ");
                string duracaoMusica = Console.ReadLine()!;

                bandas[index].Albuns[albumIndex].AddMusica(new Musica(nome: nomeMusica, artista: bandas[index])
                {
                    Duracao = double.Parse(duracaoMusica)
                });
                Console.WriteLine("Música registrada com sucesso!");
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
