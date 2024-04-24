// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using poo;

Console.WriteLine("\n\nINICIO CARRO\n");

Carro CarroVlf = new();
CarroVlf.Ano = 2022;
CarroVlf.Cor = "Verde";
CarroVlf.Modelo = "Volkswagen";
CarroVlf.Placa = "DEF5678";
CarroVlf.VelocidadeAtual = 0;

Carro CarroAhs = new(modelo: "Chevrolet",
                    cor: "Vermelho",
                    ano: 2020,
                    placa: "ABC1234",
                    velocidadeAtual: 0);

Carro CarroVfs = new(){
    Modelo = "Fiat",
    Cor = "Azul",
    Ano = 2008,
    Placa = "AVS512",
    VelocidadeAtual = 0
};


Console.WriteLine("Carro VLF");
CarroVlf.Ligar();
CarroVlf.Acelerar(20);
CarroVlf.Frear(10);

Console.WriteLine("Carro AHS");
CarroAhs.Acelerar(10);
CarroAhs.Frear(5);
CarroAhs.Ligar();

Console.WriteLine("Carro VFS");
CarroAhs.Ligar();
CarroAhs.Acelerar(2);
CarroAhs.Frear(1);


Console.WriteLine("\n\nINICIO LAMPADA\n");

Lampada minhaLampada = new();

minhaLampada.LigarDesligar(intensidade: 20);
minhaLampada.LigarDesligar();

Console.WriteLine("\n\nINICIO CONTADOR\n");

var meuContador = new Contador();
meuContador.Incrementar();
meuContador.Incrementar();
meuContador.Incrementar();
meuContador.Decrementar();
Console.WriteLine(meuContador.Status());

Console.WriteLine("\n\nINICIO TERMOMETRO\n");
Termometro termometroCozinha = new Termometro();
termometroCozinha.DefinirFaixaTemperatura(minima: 18, maxima: 24);
termometroCozinha.AjustarTemperatura(26.5);
termometroCozinha.MostrarTemperatura();
termometroCozinha.AjustarTemperatura(21);
termometroCozinha.MostrarTemperatura();

Console.WriteLine("\n\nINICIO SALA\n");
Sala minhaSala = new Sala();
minhaSala.AdicionarLampada(new Lampada());
minhaSala.AdicionarLampada(new Lampada());
minhaSala.AdicionarLampada(new Lampada());
minhaSala.AdicionarLampada(new Lampada());

minhaSala.AjustarIntensidadeTodasLampadas(intensidade: 20);

minhaSala.LigarTodasLampadas();
minhaSala.ImprimirEstadoTodasLampadas();
minhaSala.AjustarIntensidadeTodasLampadas(intensidade: 20);
minhaSala.ImprimirEstadoTodasLampadas();