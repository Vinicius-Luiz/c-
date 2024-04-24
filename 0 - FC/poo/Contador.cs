using System.IO.Pipes;

namespace poo
{
    public class Contador
    {
        public long Valor {get; set;}

        public Contador() {}
        public Contador(long Valor = 0)
        {
            this.Valor = Valor;
        }   

        public void Incrementar(long incremento = 1)
        {
            // this.Valor++;
            this.Valor += incremento;
        }

        public void Decrementar(long decremento = 1)
        {
            // this.Valor--;
            this.Valor -= decremento;
        }

        public string Status()
        {
            return $"Contador: {this.Valor}";
        }
    }
}