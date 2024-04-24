namespace poo
{
    public class Sala
    {
        public List<Lampada> MinhasLampadas { get; set; }

        public Sala()
        {
            this.MinhasLampadas = new List<Lampada>();
        }

        public void AdicionarLampada(Lampada lampada)
        {
            this.MinhasLampadas.Add(lampada);
        }

        public void LigarTodasLampadas()
        {
            foreach (Lampada lampada in MinhasLampadas)
            {
                lampada.Ligar();
            }
        }

        public void DesligarTodasLampadas()
        {
            foreach (Lampada lampada in MinhasLampadas)
            {
                lampada.Desligar();
            }
        }

        public void AjustarIntensidadeTodasLampadas(int intensidade)
        {
            foreach(Lampada lampada in MinhasLampadas)
            {
                lampada.AjustarIntensidade(intensidade);
            }
        }

                public void ImprimirEstadoTodasLampadas()
        {
            foreach(Lampada lampada in MinhasLampadas)
            {
                Console.WriteLine($"{lampada.Estado} | {lampada.Intensidade}");
            }
        }
    }
}