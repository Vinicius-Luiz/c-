using System.IO.Pipes;

namespace poo
{
    public class Lampada
    {
        public bool Estado { get; set; } = false;
        public int Intensidade { get; set; } = 0;

        public Lampada() { }

        public void LigarDesligar(int intensidade = 0)
        {
            this.Estado = !this.Estado;
            if (this.Estado)
            {
                if (intensidade > 0)
                {
                    this.Intensidade = intensidade;
                    Console.WriteLine($"Lampada ligada na itensidade {this.Intensidade}");
                }
                else
                {
                    Console.WriteLine("A lampada deve ter uma intensidade maior que 0");
                }
            }
            else
            {
                this.Intensidade = 0;
                Console.WriteLine("Lampada desligada");
            }
        }

        public void Ligar(int intensidade = 10)
        {
            if (intensidade > 0)
            {
                this.Estado = true;
                this.Intensidade = intensidade;
                Console.WriteLine($"Lampada ligada na itensidade {this.Intensidade}");
            }
            else
            {
                Console.WriteLine("A lampada deve ter uma intensidade maior que 0");
            }
        }

        public void Desligar()
        {
            this.Estado = false;
            this.Intensidade = 0;
        }

        public void AjustarIntensidade(int intensidade)
        {
            if (intensidade > 0 && this.Estado == false)
            {
                Console.WriteLine("A lampada está desligada e não pode ter intensidade positiva");
            }
            else if (intensidade < 1 && this.Estado == true)
            {
                Console.WriteLine("A lampada está ligada e não pode ter intensidade negativa");
            }
            else
            {
                this.Intensidade = intensidade;
            }
        }
    }
}