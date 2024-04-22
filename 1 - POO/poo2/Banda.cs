using System;
using System.Collections.Generic;
using System.Linq;

namespace poo2
{
    // Definição da classe Banda
    public class Banda
    {
        // Lista de álbuns da banda
        private List<Album> Albuns = new List<Album>();

        // Propriedade somente leitura para o nome da banda
        public string? Nome { get; }

        // Construtor da classe Banda
        public Banda(string nome)
        {
            Nome = nome; // Inicializa o nome da banda
        }

        // Método para adicionar um álbum à discografia da banda
        public void AddAlbum(Album album)
        {
            Albuns.Add(album); // Adiciona o álbum à lista de álbuns da banda
        }

        // Método para exibir a discografia da banda, incluindo o nome de cada álbum e sua ficha técnica
        public void Discografia()
        {
            // Itera sobre todos os álbuns da banda
            foreach (Album album in Albuns)
            {
                // Exibe o nome do álbum
                Console.WriteLine(album.Nome);
                // Exibe a ficha técnica do álbum (incluindo as músicas e a duração total)
                album.FichaTecnica();
                // Exibe uma linha em branco para separar os álbuns
                Console.WriteLine();
            }
        }
    }
}