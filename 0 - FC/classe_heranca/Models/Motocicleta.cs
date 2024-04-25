using classeHeranca;

namespace classe_heranca
{
    public class Motocicleta : Veiculo
    {
        private double CilindradaP { get; set; }
        public double Cilindrada { get { return CilindradaP; } set { CilindradaP = value; } }

        public Motocicleta(string marca, string modelo, int ano, double cilindrada) : base(marca, modelo, ano)
        {
            Cilindrada = cilindrada;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Motocicleta: {Cilindrada}");
        }
    }


}