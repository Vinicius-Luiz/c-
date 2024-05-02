using linq;


List<Livro> biblioteca = [
new Livro { Titulo = "A História do Amanhã", Autor = "Yuval Noah Harari", NumeroDePaginas = 500,
Categoria = "História" },
new Livro { Titulo = "Sapiens", Autor = "Yuval Noah Harari", NumeroDePaginas = 450, Categoria =
"Antropologia" },
new Livro { Titulo = "1984", Autor = "George Orwell", NumeroDePaginas = 328, Categoria = "Ficção" },
new Livro { Titulo = "O Sol é Para Todos", Autor = "Harper Lee", NumeroDePaginas = 384, Categoria =
"Ficção" },
new Livro { Titulo = "A Revolução dos Bichos", Autor = "George Orwell", NumeroDePaginas = 112,
Categoria = "Ficção" },
new Livro { Titulo = "Cem Anos de Solidão", Autor = "Gabriel García Márquez", NumeroDePaginas =
417, Categoria = "Ficção" },
new Livro { Titulo = "Os Miseráveis", Autor = "Victor Hugo", NumeroDePaginas = 1463, Categoria =
"Ficção Histórica" },
new Livro { Titulo = "Crime e Castigo", Autor = "Fyodor Dostoevsky", NumeroDePaginas = 671,
Categoria = "Ficção" },
new Livro { Titulo = "Breves Respostas para Grandes Questões", Autor = "Stephen Hawking",
NumeroDePaginas = 256, Categoria = "Ciência" },
new Livro { Titulo = "Uma Breve História do Tempo", Autor = "Stephen Hawking", NumeroDePaginas =
212, Categoria = "Ciência" },
new Livro { Titulo = "Os Elementos da Experiência do Usuário", Autor = "Jesse James Garrett",
NumeroDePaginas = 208, Categoria = "Design" },
new Livro { Titulo = "Design de Interação", Autor = "Jenny Preece", NumeroDePaginas = 809, Categoria
= "Design" },
new Livro { Titulo = "O Poder do Hábito", Autor = "Charles Duhigg", NumeroDePaginas = 400,
Categoria = "Autoajuda" },
new Livro { Titulo = "Como Fazer Amigos e Influenciar Pessoas", Autor = "Dale Carnegie",
NumeroDePaginas = 288, Categoria = "Autoajuda" },
new Livro { Titulo = "Subliminar", Autor = "Leonard Mlodinow", NumeroDePaginas = 304, Categoria =
"Psicologia" },
new Livro { Titulo = "Freakonomics", Autor = "Steven D. Levitt", NumeroDePaginas = 336, Categoria =
"Economia" },
new Livro { Titulo = "Outliers", Autor = "Malcolm Gladwell", NumeroDePaginas = 336, Categoria =
"Psicologia" },
new Livro { Titulo = "Don't Make Me Think", Autor = "Steve Krug", NumeroDePaginas = 200, Categoria
= "Tecnologia" },
new Livro { Titulo = "O Andar do Bêbado", Autor = "Leonard Mlodinow", NumeroDePaginas = 272,
Categoria = "Ciência" },
new Livro { Titulo = "O Gene Egoísta", Autor = "Richard Dawkins", NumeroDePaginas = 360, Categoria
= "Biologia" },
new Livro { Titulo = "O Mundo Assombrado pelos Demônios", Autor = "Carl Sagan", NumeroDePaginas
= 480, Categoria = "Ciência" }
];

var LivrosCategoria = biblioteca
    .Select(x => new { x.Titulo, x.Categoria })
    .OrderBy(x => x.Categoria)
    .ToList();

foreach (var item in LivrosCategoria)
{
    System.Console.WriteLine($"[{item.Categoria}] - {item.Titulo}");
};

System.Console.WriteLine("--------------------------------");

var LivrosPaginas = biblioteca
.Where(x => x.NumeroDePaginas > 400)
.OrderByDescending(x => x.NumeroDePaginas)
.ToList();

foreach (var item in LivrosPaginas)
{
    System.Console.WriteLine($"[{item.NumeroDePaginas} - {item.Titulo}]");
}


System.Console.WriteLine("--------------------------------");

var LivrosHistoria = biblioteca
.Where(x => x.Titulo!.Contains("História"))
.ToList();

foreach (var intem in LivrosHistoria)
{
    System.Console.WriteLine($"[{intem.Titulo}]");
}

System.Console.WriteLine("--------------------------------");

var QtdLivros = biblioteca
.GroupBy(x => x.Autor)
.Select(x => new { Categ = x.Key, Qtd = x.Count() })
;
foreach (var item in QtdLivros)
{
    System.Console.WriteLine($"{item.Categ} - {item.Qtd}");
}
System.Console.WriteLine("--------------------------------");

var Autor = biblioteca
.GroupBy(x => x.Autor)
.Select(x => new { Autor = x.Key, Qtd = x.Count() })
.Where(x => x.Qtd >= 2)
;
foreach (var item in Autor)
{
    System.Console.WriteLine($"{item.Autor} - {item.Qtd}");
}