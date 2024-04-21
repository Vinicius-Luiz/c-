using poo2;

Banda bandaSipper = new Banda(nome: "Sipper");

Album albumPink = new Album(nome: "Pink");

Musica musica1 = new Musica(nome: "Paimom Prom Dress", artista: bandaSipper)
{
    Duracao = 2.30,
    Disponivel = true
};

Musica musica2 = new Musica(nome: "Iphone 4", artista: bandaSipper)
{
    Duracao = 3.15,
    Disponivel = true
};

Musica musica3 = new Musica(nome: "K8", artista: bandaSipper)
{
    Duracao = 2.55,
    Disponivel = true
};

Musica musica4 = new Musica(nome: "Dancing in Room Song", artista: bandaSipper)
{
    Duracao = 3.20,
    Disponivel = true
};


albumPink.AddMusica(musica1);
albumPink.AddMusica(musica2);
albumPink.AddMusica(musica3);
albumPink.AddMusica(musica4);

bandaSipper.AddAlbum(albumPink);

bandaSipper.Discografia();

// -----------------------------------------------------------------------------
Console.Clear();

Pessoa peVilela = new Pessoa(nome: "Rogério Vilela");
Pessoa peGreg = new Pessoa(nome: "Greg");
Pessoa peLea = new Pessoa(nome: "Lea Maria");
Pessoa pePaul = new Pessoa(nome: "Paul Cabannes");
Pessoa peBaptista = new Pessoa(nome: "Baptista Miranda");
//

Podcast poInteligencia = new Podcast(host: peVilela, nome: "Inteligência LTDA");
//

Episodio episodio1 = new Episodio(titulo: "GREG - EVERYBODY HATES CHRIS", podcast: poInteligencia, ordem: 1, duracao: 1.52);
episodio1.AdicionarConvidados(convidado: peGreg);
//

Episodio episodio2 = new Episodio(titulo: "COMÉDIA GRINGA: LEA MARIA, PAUL CABANNES E BAPTISTA MIRANDA", podcast: poInteligencia, ordem: 2, duracao: 3.40);
episodio2.AdicionarConvidados(convidado: peLea);
episodio2.AdicionarConvidados(convidado: pePaul);
episodio2.AdicionarConvidados(convidado: peBaptista);
//

poInteligencia.AdicionarEpidosio(episodio2);
poInteligencia.AdicionarEpidosio(episodio1);
poInteligencia.ExibirDetalhes();