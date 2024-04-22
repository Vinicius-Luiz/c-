
namespace poo;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("REGISTRAR BANDAS");
        Console.Write("Nome da banda:\n> ");

        string NovaBanda = Console.ReadLine()!;
        bandas.Add(new Banda(nome: NovaBanda));

        Console.Clear();
        Console.WriteLine($"Banda {NovaBanda} registrada");
    }
}
