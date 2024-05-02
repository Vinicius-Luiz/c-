namespace classe_generica;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("[1] - Arvore Binária de Inteiros");
            Console.WriteLine("[2] - Arvore Binária de Funcionários");
            Console.WriteLine("[3] - Lista de Contas bancárias");
            Console.WriteLine("\n");
            string? op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    #region ARVORE COM INT
                    ArvoreBinaria<int> arvore1 = new();

                    arvore1.Inserir(10);
                    arvore1.Inserir(5);
                    arvore1.Inserir(15);
                    arvore1.Inserir(3);
                    arvore1.Inserir(7);
                    arvore1.Inserir(13);
                    arvore1.Inserir(17);
                    arvore1.Inserir(1);
                    arvore1.Inserir(14);

                    Console.WriteLine(arvore1.Buscar(14));

                    #endregion
                    break;

                case "2":
                    #region ARVORE COM FUNCIONÁRIOS
                    ArvoreBinaria<Funcionario> arvore2 = new();

                    Funcionario fun1 = new(Matricula: 10) { Nome = "Vinicius", Salario = 1000 };
                    Funcionario fun2 = new(Matricula: 5) { Nome = "Henrique", Salario = 2000 };
                    Funcionario fun3 = new(Matricula: 15) { Nome = "Luis", Salario = 3000 };
                    Funcionario fun4 = new(Matricula: 3) { Nome = "Vital", Salario = 4000 };
                    Funcionario fun5 = new(Matricula: 7) { Nome = "Felipe", Salario = 5000 };
                    Funcionario fun6 = new(Matricula: 13) { Nome = "Lews", Salario = 6000 };
                    Funcionario fun7 = new(Matricula: 17) { Nome = "Carlos", Salario = 7000 };
                    Funcionario fun8 = new(Matricula: 1) { Nome = "Gabi", Salario = 8000 };
                    Funcionario fun9 = new(Matricula: 14) { Nome = "Amanda", Salario = 9000 };

                    arvore2.Inserir(fun1);
                    arvore2.Inserir(fun2);
                    arvore2.Inserir(fun3);
                    arvore2.Inserir(fun4);
                    arvore2.Inserir(fun5);
                    arvore2.Inserir(fun6);
                    arvore2.Inserir(fun7);
                    arvore2.Inserir(fun8);
                    arvore2.Inserir(fun9);

                    Console.WriteLine(arvore2.Buscar(fun5));

                    #endregion
                    break;

                case "3":
                    #region LISTA DE CONTAS
                    Banco BBradesco = new(cnpj: "12.345.678/0001-90", tamanho: 3) { Nome = "Bradesco" };
                    Banco BItau = new(cnpj: "12.345.678/0001-90", tamanho: 1) { Nome = "Itau" };

                    Conta CVini = new("123.456.789-10") { Nome = "Vinicius" };
                    CVini.Depositar(1000);
                    Conta CHenrique = new("123.456.789-10") { Nome = "Henrique" };
                    CHenrique.Sacar(2000);
                    Conta CLuis = new("123.456.789-10") { Nome = "Luis", Saldo = 3000 };
                    CLuis.Sacar(1000);
                    Conta CAmanda = new("123.456.789-10") { Nome = "Amanda", Saldo = 4000 };
                    CAmanda.Sacar(1000);
                    Conta CGabi = new("123.456.789-10") { Nome = "Gabi", Saldo = 5000 };
                    CGabi.Sacar(1000);

                    BBradesco.Inserir(CVini);
                    BBradesco.Inserir(CHenrique);
                    BBradesco.Inserir(CLuis);
                    BItau.Inserir(CAmanda);

                    BBradesco.MostrarContas();
                    BItau.MostrarContas();

                    BBradesco.Remover(CHenrique);
                    // BItau.Inserir(CGabi);
                    #endregion
                    break;

            }
        }
    }
}
