using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo2
{
    public class Podcast
    {
        private List<Episodio> Episodios = new List<Episodio>();
        public Pessoa Host { get; }
        public string Nome { get; }
        public int TotalEpisodios = 0;

        public Podcast(Pessoa host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public void AdicionarEpidosio(Episodio episodio)
        {
            Episodios.Add(episodio);
            TotalEpisodios++;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"{Nome} | Host {Host.Nome}");
            foreach (Episodio episodio in Episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo + '\n');
            }
            Console.WriteLine($"\nTotal de episodios: {TotalEpisodios}\n");
        }
    }
}