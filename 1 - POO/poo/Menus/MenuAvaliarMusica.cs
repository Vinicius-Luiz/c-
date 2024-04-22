namespace poo;

internal class MenuAvaliarMusica : Menu
{
    override public void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("AVALIAR MUSICAS");

        Console.Write("Nome da banda:\n> ");
        string bandaAvaliada = Console.ReadLine()!;

        Console.Write("Nome do album:\n> ");
        string albumAvaliado = Console.ReadLine()!;

        Console.Write("Nome da música:\n> ");
        string nomeMusica = Console.ReadLine()!;

        int bandaIndex = bandas.FindIndex(banda => banda.Nome == bandaAvaliada);
        if (bandaIndex >= 0)
        {
            int albumIndex = bandas[bandaIndex].Albuns.FindIndex(album => album.Nome == albumAvaliado);
            if (albumIndex >= 0)
            {
                int musicaIndex = bandas[bandaIndex].Albuns[albumIndex].Musicas.FindIndex(Musica => Musica.Nome == nomeMusica);
                if (musicaIndex >= 0)
                {
                    Console.Write("Avaliação:\n> ");
                    Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
                    bandas[bandaIndex].Albuns[albumIndex].Musicas[musicaIndex].AddAvaliacao(avaliacao);
                    Console.WriteLine($"{nomeMusica} avaliado com sucesso com a nota {avaliacao.Nota}!");
                }
                else
                {
                    Console.WriteLine("Música inexistente");
                }
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