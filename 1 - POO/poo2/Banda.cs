using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo2
{
    public class Banda
    {
        private List<Album> Albuns = new List<Album>();
        public string? Nome { get; }

        public Banda(string nome)
        {
            Nome = nome;
        }

        public void AddAlbum(Album album)
        {
            Albuns.Add(album);
        }

        public void Discografia()
        {
            foreach (Album album in Albuns)
            {
                Console.WriteLine(album.Nome);
                album.FichaTecnica();
                Console.WriteLine();
            }
        }
    }
}