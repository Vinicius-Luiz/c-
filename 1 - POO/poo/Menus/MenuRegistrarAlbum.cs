
namespace poo;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("REGISTRAR ALBUNS");
        Console.Write("Nome do album:\n> ");
        string nomeAlbum = Console.ReadLine()!;

        Console.Write("Nome da banda:\n> ");
        string nomeBanda = Console.ReadLine()!;

        int index = bandas.FindIndex(banda => banda.Nome == nomeBanda);
        if (index >= 0)
        {
            bandas[index].AddAlbum(new Album(nomeAlbum));
            Console.WriteLine($"Album {nomeAlbum} registrado para a banda {nomeBanda}");
        }
        else
        {
            Console.WriteLine("Banda inexistente");
        }
    }
}
