// TODO Forma 1
// int[] idades = new int[5];

// TODO Forma 2
// List<int> idades = new List<int>(5);

// TODO Forma 3
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