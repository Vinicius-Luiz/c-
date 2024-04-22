using System;
using System.Collections.Generic;
using System.Linq;

namespace poo2
{
    // Definição da classe Album
    public class Album
    {
        // Lista de músicas pertencentes ao álbum
        private List<Musica> Musicas = new List<Musica>();

        // Propriedade somente leitura para o nome do álbum
        public string? Nome { get; }

        // Propriedade somente leitura para a duração total do álbum (calculada como a soma das durações das músicas)
        public double DuracaoTotal => Musicas.Sum(m => m.Duracao);

        // Construtor da classe Album
        public Album(string nome)
        {
            Nome = nome; // Inicializa o nome do álbum
        }

        // Método para adicionar uma música ao álbum
        public void AddMusica(Musica musica)
        {
            Musicas.Add(musica); // Adiciona a música à lista de músicas do álbum
        }

        // Método para exibir a ficha técnica do álbum, incluindo a ficha técnica de cada música e a duração total do álbum
        public void FichaTecnica()
        {
            // Itera sobre todas as músicas do álbum
            foreach (Musica musica in Musicas)
            {
                musica.FichaTecnica(); // Exibe a ficha técnica de cada música
            }
            // Exibe a duração total do álbum
            Console.WriteLine($"Duracao total: {DuracaoTotal}min");
        }
    }
}
