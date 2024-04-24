namespace encapsulamento.Models
{
    public class Pessoa
    {
        private int prvIdade;
        public int Idade
        {
            get { return prvIdade; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Idade inválida");
                }
                prvIdade = value;
            }
        }

        public Pessoa(int idadeInicial)
        {
            Idade = idadeInicial;
        }

        public void Aniversario()
        {
            Idade++;
        }
    }
}