using System.IO.Pipes;

namespace poo // Define o namespace 'poo'
{
    public class Carro // Define a classe pública 'Carro'
    // ordem de criação:
    // 1º atributos
    // 2º construtor
    // 3º métodos
    {
        // Propriedades obrigatórias que permitem leitura e escrita
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public int Ano { get; set; }
        public string? Placa { get; set; }
        public double VelocidadeAtual { get; set; }
        public bool Ligado { get; set; } = false;

        // Construtor da classe Carro
        // Recebe cinco parâmetros: modelo, cor, ano, placa e velocidadeAtual

        public Carro () { }

        public Carro(string modelo, string cor, int ano, string placa, double velocidadeAtual)
        {
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Placa = placa;
            VelocidadeAtual = velocidadeAtual;
        }


        // 'void' indica que o método não retorna nenhum valor

        // Método para acelerar o carro

        public void Acelerar(double incremento)
        {
            if (this.Ligado)
            {
                this.VelocidadeAtual += incremento;
                Console.WriteLine($"A velocidade do carro subiu para {this.VelocidadeAtual}");
            }
            else
            {
                Console.WriteLine("O carro não está ligado");
            }
        }

        // Método para freiar o carro
        public void Frear(double decremento)
        {
            if (this.Ligado)
            {
                this.VelocidadeAtual -= decremento;
                Console.WriteLine($"A velocidade do carro desceu para {this.VelocidadeAtual}");
            }
            else
            {
                Console.WriteLine("O carro não está ligado");
            }
        }

        // Método para ligar o carro e retornar uma mensagem indicando que foi ligado
        public void Ligar() => this.Ligado = true;
    }
}
