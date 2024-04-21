using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo2
{
    public class Album
    {
        private List<Musica> Musicas = new List<Musica>();
        public string? Nome { get; }
        public double DuracaoTotal => Musicas.Sum(m => m.Duracao);

        public Album(string nome)
        {
            Nome = nome;
        }

        public void AddMusica(Musica musica)
        {
            Musicas.Add(musica);
        }

        public void FichaTecnica()
        {
            foreach (Musica musica in Musicas)
            {
                musica.FichaTecnica();
            }
            Console.WriteLine($"Duracao total: {DuracaoTotal}min");
        }
    }
}