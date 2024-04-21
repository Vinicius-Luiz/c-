// List<string> é uma coleção genérica que pode conter uma sequência de strings
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Threading;


Dictionary<string, List<int>> bandas = new()
{
    { "30PRAUM", new List<int> { 10, 10, 4, 5, 9, 6, 5 } },
    { "Charlie Brown Jr", new List<int> { 9, 9, 8, 9, 6, 5, 8 } },
    { "Sipper", new List<int>() }
};

// Funções estáticas não dependem do estado de um objeto específico
// e podem ser chamadas diretamente a partir do código sem a necessidade de criar uma instância da classe
int ExibirMensagemMenu()
{
    Console.Write(@"

█░█ █ █▄░█ █ █▀▀ █ █░█ █▀   █░░ █░█ █ ▀█
▀▄▀ █ █░▀█ █ █▄▄ █ █▄█ ▄█   █▄▄ █▄█ █ █▄

[1] Registrar uma banda
[2] Mostrar todas as bandas
[3] Avaliar uma banda
[4] Exibir a média de uma banda
[0] Sair
> ");

    string op = Console.ReadLine()!;
    int option = int.Parse(op);

    switch (option)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MostrarMediaBanda();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    return option;
}

void MostrarTitulo(string titulo)
{
    int tituloLength = titulo.Length;
    string style = string.Empty.PadLeft(tituloLength, '=');

    Console.Clear();
    Console.WriteLine(style);
    Console.WriteLine(titulo);
    Console.WriteLine(style + '\n');
}

void RegistrarBandas()
{

    MostrarTitulo("REGISTRAR BANDAS");
    Console.Write("Nome da banda:\n> ");

    string NovaBanda = Console.ReadLine()!;
    bandas.Add(NovaBanda, new List<int>());

    Console.Clear();
    Console.WriteLine($"Banda {NovaBanda} registrada");
}

void MostrarBandas()
{
    MostrarTitulo("BANDAS CADASTRADAS");

    int i = 1;
    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"Banda {i} - {banda}");
        i++;
    }

    // for (int i = 0; i < bandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda {i+1} - {bandas[i]}");
    // }
}

void AvaliarBanda()
{
    MostrarTitulo("AVALIAR BANDAS");
    Console.Write("Nome da banda:\n> ");

    string banda = Console.ReadLine()!;

    if (bandas.ContainsKey(banda))
    {
        Console.Write("Avaliação: ");
        int avaliacao = int.Parse(Console.ReadLine()!);
        bandas[banda].Add(avaliacao);
        Console.WriteLine($"{banda} avaliada com sucesso!");
    }
    else
    {
        Console.WriteLine("Banda inexistente");
    }
}

void MostrarMediaBanda()
{
    MostrarTitulo("MEDIA DE BANDAS");
    Console.Write("Nome da banda:\n> ");

    string banda = Console.ReadLine()!;

    if (bandas.ContainsKey(banda))
    {
        int qtdAvaliacoes = bandas[banda].Count;

        if (qtdAvaliacoes == 0)
        {
            Console.WriteLine($"Nenhuma avaliação registrada para a banda {banda}");
        }
        else
        {
            // double media = 0;
            // foreach (int avaliacao in bandas[banda])
            // {
            //     media += avaliacao;
            // }
            // media /= qtdAvaliacoes;
            double media = bandas[banda].Average();
            Console.WriteLine($"Avaliação da banda {banda}: {media}");
        }
    }
    else
    {
        Console.WriteLine("Banda inexistente");
    }
}

while (true)
{
    int option = ExibirMensagemMenu();
    Thread.Sleep(2500);
    Console.Clear();

    if (option == 0)
    {
        break;
    }
}