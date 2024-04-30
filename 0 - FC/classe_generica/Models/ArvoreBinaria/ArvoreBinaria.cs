namespace classe_generica;

public class ArvoreBinaria<T> where T : IComparable<T>
{
    private class No
    {
        public T Dado;
        public No? Esquerda;
        public No? Direita;

        public No(T dado)
        {
            Dado = dado;
            Esquerda = null;
            Direita = null;
        }
    }

    private No? raiz;

    public int Altura { get; private set; }
    public int Tamanho { get; private set; }
    public T? Minimo { get; private set; }
    public T? Maximo { get; private set; }

    public bool EstaVazia()
    {
        return raiz == null;
    }

    public void Limpar()
    {
        raiz = null;
        Altura = 0;
        Tamanho = 0;
        Minimo = default(T);
        Maximo = default(T);
    }

    public void Inserir(T valor)
    {
        raiz = InserirRecursivamente(raiz!, valor);
        Tamanho++;
    }

    private No InserirRecursivamente(No no, T valor)
    {
        if (no == null)
        {
            return new No(valor);
        }

        if (valor.CompareTo(no.Dado) < 0)
        {
            no.Esquerda = InserirRecursivamente(no.Esquerda!, valor);
        }
        else if (valor.CompareTo(no.Dado) > 0)
        {
            no.Direita = InserirRecursivamente(no.Direita!, valor);
        }

        return no;
    }

    public T? Buscar(T valor)
    {
        return BuscarRecursivamente(raiz!, valor);
    }

    private T? BuscarRecursivamente(No no, T valor)
    {
        Console.WriteLine($"Buscando {valor} em {no.Dado}");
        if (no == null || valor.CompareTo(no.Dado) == 0)
        {
            return no != null ? no.Dado : default(T);
        }

        if (valor.CompareTo(no.Dado) < 0)
        {
            return BuscarRecursivamente(no.Esquerda!, valor);
        }
        else
        {
            return BuscarRecursivamente(no.Direita!, valor);
        }
    }

    public void Remover(T valor)
    {
        raiz = RemoverRecursivamente(raiz!, valor);
        Tamanho--;
    }

    private No? RemoverRecursivamente(No no, T valor)
    {
        if (no == null)
        {
            return null;
        }

        if (valor.CompareTo(no.Dado) < 0)
        {
            no.Esquerda = RemoverRecursivamente(no.Esquerda!, valor);
        }
        else if (valor.CompareTo(no.Dado) > 0)
        {
            no.Direita = RemoverRecursivamente(no.Direita!, valor);
        }
        else
        {
            if (no.Esquerda == null)
            {
                return no.Direita!;
            }
            else if (no.Direita == null)
            {
                return no.Esquerda;
            }

            no.Dado = EncontrarMinimo(no.Direita);
            no.Direita = RemoverRecursivamente(no.Direita, no.Dado);
        }

        return no;
    }

    private T EncontrarMinimo(No no)
    {
        while (no.Esquerda != null)
        {
            no = no.Esquerda;
        }
        return no.Dado;
    }
}