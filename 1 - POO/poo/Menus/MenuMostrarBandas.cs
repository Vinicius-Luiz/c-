
namespace poo;
internal class MenuMostrarBandas : Menu
{
    public override void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("BANDAS CADASTRADAS");

        int i = 1;
        foreach (Banda banda in bandas)
        {
            Console.WriteLine($"Banda {i} - {banda.Nome}");
            i++;
        }
    }
}
