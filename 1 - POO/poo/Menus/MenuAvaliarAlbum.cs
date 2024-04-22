namespace poo;

internal class MenuAvaliarAlbum : Menu
{
    override public void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("AVALIAR ALBUMS");

        Console.Write("Nome da banda:\n> ");
        string bandaAvaliada = Console.ReadLine()!;

        Console.Write("Nome do album:\n> ");
        string albumAvaliado = Console.ReadLine()!;

        int bandaIndex = bandas.FindIndex(banda => banda.Nome == bandaAvaliada);
        if (bandaIndex >= 0)
        {
            int albumIndex = bandas[bandaIndex].Albuns.FindIndex(album => album.Nome == albumAvaliado);
            if (albumIndex >= 0)
            {
                Console.Write("Avaliação:\n> ");
                Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
                bandas[bandaIndex].Albuns[albumIndex].AddAvaliacao(avaliacao);
                Console.WriteLine($"{albumAvaliado} avaliado com sucesso com a nota {avaliacao.Nota}!");
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
