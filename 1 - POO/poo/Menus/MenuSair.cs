namespace poo;

internal class MenuSair : Menu
{
    public override void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("SAINDO...");
        Thread.Sleep(2000);
        Environment.Exit(0);
    }
}
