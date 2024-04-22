
namespace poo;
internal class MenuMostrarDiscografiaBanda : Menu
{
    public override void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("DISCIFRÁRIA DE BANDAS");
        Console.Write("Nome da banda:\n> ");
        string nomeBanda = Console.ReadLine()!;

        int index = bandas.FindIndex(banda => banda.Nome == nomeBanda);
        if (index >= 0)
        {
            bandas[index].Discografia();
        }
        else
        {
            Console.WriteLine("Banda inexistente");
        }
    }
}