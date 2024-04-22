namespace poo;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(List<Banda> bandas)
    {
        base.Executar(bandas);
        MostrarTitulo("AVALIAR BANDAS");
        Console.Write("Nome da banda:\n> ");

        string bandaAvaliada = Console.ReadLine()!;

        int index = bandas.FindIndex(banda => banda.Nome == bandaAvaliada);

        if (index >= 0)
        {
            Console.Write("Avaliação:\n> ");

            // Lê a entrada do usuário e converte-a em um objeto Avaliacao usando o método estático Parse da classe Avaliacao
            Avaliacao avaliacao = Avaliacao.Parse(Console.ReadLine()!);
            bandas[index].AddAvaliacao(avaliacao);
            Console.WriteLine($"{bandaAvaliada} avaliada com sucesso com a nota {avaliacao.Nota}!");
        }
        else
        {
            Console.WriteLine("Banda inexistente");
        }
    }
}