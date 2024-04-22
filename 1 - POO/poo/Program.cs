using System.Runtime.CompilerServices;
using poo;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Banda> bandas = new();

        // Criar objetos 
        Banda banda1 = new Banda(nome: "30PRAUM");
        Banda banda2 = new Banda(nome: "Charlie Brown Jr");
        Banda banda3 = new Banda(nome: "Sipper");

        banda1.AddAvaliacao(avaliacao: new Avaliacao(nota: 10));
        banda1.AddAvaliacao(avaliacao: new Avaliacao(nota: 4));
        banda1.AddAvaliacao(avaliacao: new Avaliacao(nota: 7));

        banda2.AddAvaliacao(avaliacao: new Avaliacao(nota: 9));
        banda2.AddAvaliacao(avaliacao: new Avaliacao(nota: 6));
        banda2.AddAvaliacao(avaliacao: new Avaliacao(nota: 8));

        bandas.Add(banda1);
        bandas.Add(banda2);
        bandas.Add(banda3);

        bandas[2].AddAlbum(album: new Album("Pink"));

        bandas[2].Albuns[0].AddMusica(musica: new Musica(nome: "Paimom Prom Dress", artista: bandas[2])
        {
            Duracao = 3.14
        });

        bandas[2].Albuns[0].Musicas[0].AddAvaliacao(new Avaliacao(nota: 8));
        bandas[2].Albuns[0].Musicas[0].AddAvaliacao(new Avaliacao(nota: 9));
        bandas[2].Albuns[0].Musicas[0].AddAvaliacao(new Avaliacao(nota: 5));
        // Criar objetos 

        Dictionary<int, Menu> menuOptions = new()
        {
            { 1, new MenuRegistrarBanda() },
            { 2, new MenuMostrarBandas() },
            { 3, new MenuAvaliarBanda() },
            { 4, new MenuMostrarMediaBanda() },
            { 5, new MenuRegistrarAlbum() },
            { 6, new MenuMostrarDiscografiaBanda() },
            { 7, new MenuAvaliarAlbum() },
            { 8, new MenuMostrarMediaAlbum() },
            { 9, new MenuRegistrarMusica() },
            { 10, new MenuAvaliarMusica() },
            { 11, new MenuMostrarMediaMusica() },
            { 0, new MenuSair() }
        };

        // Funções estáticas não dependem do estado de um objeto específico
        // e podem ser chamadas diretamente a partir do código sem a necessidade de criar uma instância da classe
        void ExibirMensagemMenu()
        {
            Console.Write(@"

█░█ █ █▄░█ █ █▀▀ █ █░█ █▀   █░░ █░█ █ ▀█
▀▄▀ █ █░▀█ █ █▄▄ █ █▄█ ▄█   █▄▄ █▄█ █ █▄

[ MENU BANDAS ]
[1] Registrar uma banda
[2] Mostrar todas as bandas
[3] Avaliar uma banda
[4] Mostrar a média de uma banda

[ MENU ALBUNS ]
[5] Registrar um album
[6] Exibir a discografia de uma banda
[7] Avaliar um album
[8] Mostrar a média de um album

[ MENU MUSICA ]
[9] Registrar uma musica
[10] Avaliar uma musica
[11] Mostrar a média de uma musica

[ MENU SAIR ]
[0] Sair

> ");

            string op = Console.ReadLine()!;
            int option = int.Parse(op);

            if (menuOptions.ContainsKey(option))
            {
                Menu menu = menuOptions[option];
                menu.Executar(bandas);
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }

        while (true)
        {
            ExibirMensagemMenu();
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}