using System;

namespace arrays_collections
{
    // A classe ListConta<T> é uma classe genérica que herda da classe List<T>.
    public class ListConta<T> : List<T>
    {
        // Lista de contas.
        public List<Conta>? Contas = new();

        // Indexador personalizado que retorna ou define uma conta com base no índice.
        public new Conta this[int index]
        {
            get
            {
                return Contas![index];
            }
            set
            {
                Contas![index] = value;
            }
        }

        // Método para adicionar uma nova conta à lista de contas.
        public void Add(Conta conta)
        {
            // Verifica se a conta já existe na lista.
            foreach (Conta contaExistente in Contas!)
            {
                if (contaExistente.Numero == conta.Numero)
                    throw new ContaException("Conta já existente");
            }
            // Adiciona a conta à lista de contas.
            Contas!.Add(conta);
        }

        // Método para remover uma conta da lista de contas.
        public void Remove(Conta conta)
        {
            // Remove a conta da lista de contas.
            Contas!.Remove(conta);
        }

        // Método para remover uma conta da lista de contas com base no índice.
        public new void RemoveAt(int index)
        {
            // Verifica se o índice está dentro dos limites da lista de contas.
            if (index < 0 || index >= Contas!.Count)
            {
                throw new ContaException("Index de conta inexistente");
            }
            // Remove a conta da lista de contas.
            Contas!.RemoveAt(index);
        }

        // Método para ordenar a lista de contas.
        public new void Sort()
        {
            // Ordena a lista de contas.
            Contas?.Sort();
        }

        /// Método de busca por número de conta.
        /// <returns>A conta correspondente ao número especificado.</returns>
        /// <exception cref="ContaException">Lançada quando a conta não é encontrada.</exception>
        public Conta SearchByNumero(int numero)
        {
            // Verifica se a conta existe na lista de contas. (LINQ com FirstOrDefault: Método de Busca)
            Conta? contaSearch = Contas!.Where(c => c.Numero == numero).FirstOrDefault();

            if (contaSearch is not null)
            {
                return contaSearch!;
            }
            else
            {
                throw new ContaException($"Conta {numero} inexistente");
            }
        }

        /// Método de busca por CPF.
        /// <returns>Uma lista de contas correspondentes ao CPF especificado.</returns>
        /// <exception cref="ContaException">Lançada quando a conta não é encontrada.</exception>
        public List<Conta> SearchByCpf(string cpf)
        {
            // Verifica se a conta existe na lista de contas. (LINQ to Objects)
            var contaSearch = (
                    from conta in Contas
                    where conta.Cpf == cpf
                    select conta
            ).ToList();

            if (contaSearch is not null)
            {
                return contaSearch;
            }
            else { throw new ContaException($"Conta {cpf} inexistente"); }
        }



        // Método para exibir as contas na lista.
        public void Show()
        {
            // Verifica se a lista de contas está vazia.
            if (Contas!.Count == 0)
            {
                throw new ContaException("Lista de contas vazia");
            }
            else
            {
                // Exibe cada conta na lista de contas.
                foreach (Conta conta in Contas!)
                {
                    Console.WriteLine(conta);
                }
            }
        }
    }
}