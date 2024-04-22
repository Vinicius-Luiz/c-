namespace poo;

internal class Avaliacao
{
    public int Nota { get; }
    private readonly int NotaMinima = 0;
    private readonly int NotaMaxima = 10;

    public Avaliacao(int nota)
    {
        if (nota < NotaMinima || nota > NotaMaxima)
        {
            throw new Exception("Nota inválida");
        }
        Nota = nota;
    }

    // Método estático para fazer o parsing de uma string para uma instância de Avaliacao
    public static Avaliacao Parse(string nota)
    {
        // Converte a string para um número inteiro usando int.Parse
        // e cria uma nova instância de Avaliacao com o valor convertido
        return new Avaliacao(int.Parse(nota));
    }
}
