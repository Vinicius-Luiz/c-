using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo2
{
    public class Musica
    {
        public string? Nome { get; }
        public Banda? Artista { get; }
        public double Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string? Descricao => $"{Artista} - {Nome}";

        public Musica(string nome, Banda artista)
        {
            Nome = nome;
            Artista = artista;
        }
        public void FichaTecnica()
        {
            Console.WriteLine($"Descricao {Descricao} | {Duracao}ms | {(Disponivel ? "Disponível" : "Indisponível")}");
        }
    }
}