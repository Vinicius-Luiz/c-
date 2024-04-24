namespace poo
{
    public class Termometro
    {
        private object? faixa;

        public double Temperatura { get; set; }
        public double TemperaturaMinima { get; set; }
        public double TemperaturaMaxima { get; set; }

        public Termometro() { }
        public Termometro(double temperatura)
        {
            this.Temperatura = temperatura;
        }

        public void AjustarTemperatura(double novaTemperatura)
        {
            this.Temperatura = novaTemperatura;

        }

        public void DefinirFaixaTemperatura(double minima, double maxima)
        {
            this.TemperaturaMinima = minima;
            this.TemperaturaMaxima = maxima;
        }

        public void MostrarTemperatura()
        {
            if (this.Temperatura >= this.TemperaturaMinima && this.Temperatura <= this.TemperaturaMaxima)
            {
                faixa = "Temperatura na faixa";
            }
            else
            {
                faixa = "Temperatura fora da faixa";
            }
            Console.WriteLine($"Temperatura: {this.Temperatura} | {faixa}");
        }
    }
}