using System.Runtime.CompilerServices;

namespace arrays_collections
{
    // A classe Conta implementa a interface IComparable<Conta> para permitir a comparação entre instâncias de Conta.
    public class Conta : IComparable<Conta>
    {
        // Campos privados que armazenam os valores dos atributos da conta.
        private readonly int NumeroP; // Armazena o número da conta.
        private readonly string? CpfP; // Armazena o CPF associado à conta.
        private int SaldoP; // Armazena o saldo da conta.
        private int LimiteP; // Armazena o limite da conta.

        // Propriedades públicas que fornecem acesso aos atributos da conta.
        // A propriedade Numero só possui um getter e é somente leitura.
        public int Numero
        {
            get { return NumeroP; }
        }

        // A propriedade Cpf só possui um getter e é somente leitura.
        public string Cpf
        {
            get { return CpfP!; }
        }

        // A propriedade Saldo possui um getter e um setter para acesso e modificação do saldo.
        public int Saldo
        {
            get { return SaldoP; }
            set { SaldoP = value; }
        }

        // A propriedade Limite possui um getter e um setter para acesso e modificação do limite.
        public int Limite
        {
            get { return LimiteP; }
            set { LimiteP = value; }
        }

        // Construtor da classe Conta que inicializa os campos NumeroP e CpfP.
        public Conta(int numero, string cpf)
        {
            NumeroP = numero;
            CpfP = cpf;
        }

        // Sobrescreve o método ToString para fornecer uma representação em string da conta.
        public override string ToString()
        {
            return $"Número: {Numero} | CPF: {Cpf} | Saldo: {Saldo} | Limite: {Limite}";
        }

        // Implementação do método CompareTo da interface IComparable<Conta>.
        // Compara duas instâncias de Conta com base no número da conta.
        public int CompareTo(Conta? other)
        {
            if (other is null)
            {
                return 1;
            }
            else
            {
                return Numero.CompareTo(other.Numero);
            }
        }
    }
}