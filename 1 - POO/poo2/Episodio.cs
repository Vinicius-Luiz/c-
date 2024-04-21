using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo2
{
    public class Episodio
    {
        private List<Pessoa> Convidados = new List<Pessoa>();
        public string Titulo { get; }
        public int Ordem { get; }
        public double Duracao { get; }
        public Podcast Podcast { get; }
        public string Resumo
        {
            get
            {
                string convidados = "";
                foreach (Pessoa convidado in Convidados)
                {
                    convidados += convidado.Nome + ", ";
                }
                convidados = convidados.TrimEnd(',', ' ');

                return $"[{Ordem}] {Titulo} ({Duracao}min)\n- {convidados}";
            }
        }


        public Episodio(string titulo, Podcast podcast, int ordem, double duracao)
        {
            Titulo = titulo;
            Ordem = ordem;
            Duracao = duracao;
            Podcast = podcast;
        }

        public void AdicionarConvidados(Pessoa convidado)
        {
            Convidados.Add(convidado);
        }
    }
}