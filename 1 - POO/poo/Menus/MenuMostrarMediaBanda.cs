namespace poo;
internal class MenuMostrarMediaBanda : Menu
{
    public override void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("MEDIA DE BANDAS");
        Console.Write("Nome da banda:\n> ");

        string bandaPesquisada = Console.ReadLine()!;

        int index = bandas.FindIndex(banda => banda.Nome == bandaPesquisada);

        if (index >= 0)
        {
            int qtdAvaliacoes = bandas[index].QtdAvaliacoes();

            if (qtdAvaliacoes == 0)
            {
                Console.WriteLine($"Nenhuma avaliação registrada para a banda {bandaPesquisada}");
            }
            else
            {
                double media = bandas[index].Media;
                Console.WriteLine($"Avaliação da banda {bandaPesquisada}: {media}");
            }
        }
        else
        {
            Console.WriteLine("Banda inexistente");
        }
    }
}