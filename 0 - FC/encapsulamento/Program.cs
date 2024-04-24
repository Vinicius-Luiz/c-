using encapsulamento;
using encapsulamento.Models;

Termometro termometro = new();

Console.WriteLine(termometro.LerTemperatura());
termometro.AjustarTemperatura(25.5);
Console.WriteLine(termometro.LerTemperatura());

Console.Clear();

Pessoa pessoa = new(15);

pessoa.Aniversario();
Console.WriteLine(pessoa.Idade);
