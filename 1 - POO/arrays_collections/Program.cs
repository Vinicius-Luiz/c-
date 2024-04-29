# region LIST
// TODO Forma 1
// int[] idades = new int[5];

// TODO Forma 2
// List<int> idades = new List<int>(5);

// TODO Forma 3
using System.ComponentModel;
using System.Xml.Schema;
using arrays_collections;

List<int> idades = new(5)
{
    1,
    3,
    5,
    7,
    11
};

// TODO Para a forma 1
// double media1 = idades.Sum() / idades.Length;
// int soma = 0;
// for (int i = 0; i < idades.Length; i++)
// {
//     soma += idades[i];
// }
// double media2 = soma / idades.Length;

// TODO Para a forma 2 e 3
double media1 = idades.Sum() / idades.Count;
double media2 = idades.Average();


Console.WriteLine($"A média das idades é: {media1} | {media2}");
Console.Clear();

# endregion

# region ARRAY
// Forma 1
// Array amostra = Array.CreateInstance(typeof(double), 6);

// Forma 2
Array amostra = new double[6];
amostra.SetValue(3.1, 1);
amostra.SetValue(4.2, 0);
amostra.SetValue(5.2, 2);
amostra.SetValue(6.2, 3);
amostra.SetValue(7.1, 4);
amostra.SetValue(8.2, 5);

static void Mediana(Array amostra)
{
    if ((amostra is null) || (amostra.Length == 0))
    {
        Console.WriteLine("\nVazio");
    }
    else
    {
        // Cria uma cópia da amostra e a ordena
        double[] amostraOrdenada = (double[])amostra.Clone();
        Array.Sort(amostraOrdenada);

        int tamanho = amostraOrdenada.Length;
        int meio = tamanho / 2;

        double mediana = (tamanho % 2 != 0) ? amostraOrdenada[meio] : (amostraOrdenada[meio] + amostraOrdenada[meio - 1]) / 2;

        Console.WriteLine(mediana);
    }
}


Mediana(amostra);

# endregion

# region CONTA
Console.Clear();
ListConta<Conta> ListContas = new();

try
{
    ListContas.Show();
}
catch (ContaException e)
{
    Console.WriteLine(e.Message);
}

Conta conta1 = new(numero: 1, cpf: "123.456.789-00") { Saldo = 1000 };
Conta conta2 = new(numero: 2, cpf: "987.654.321-00") { Limite = 2000 };
Conta conta3 = new(numero: 3, cpf: "123.456.789-00");
Conta conta4 = new(numero: 4, cpf: "978.456.123-00") { Saldo = 500, Limite = 1000 };

Console.WriteLine("\nAdicionando contas");
ListContas.Add(conta3);
ListContas.Add(conta1);
ListContas.Add(conta2);
ListContas.Show();

Console.WriteLine("\nOrdenando contas");
ListContas.Sort();
ListContas.Show();

Console.WriteLine("\nProcurando conta 3");
Console.WriteLine(ListContas.SearchByNumero(numero: 3));

Console.WriteLine("\nProcurando contas 123.456.789-00");
foreach (Conta conta in ListContas.SearchByCpf(cpf: "123.456.789-00"))
{
    Console.WriteLine(conta);
}

Console.WriteLine("\nRemovendo conta 3");
ListContas.Remove(conta3);
ListContas.Show();

Console.WriteLine("\nRemovendo conta pelo indice 1");
ListContas.RemoveAt(1);
ListContas.Show();

Console.WriteLine("\nAdicionando conta 4 e mostrando pelo indice 1");
ListContas.Add(conta4);
Console.WriteLine(ListContas[1]);

#endregion