namespace poo;

internal class Menu
{
    public static void MostrarTitulo(string titulo)
    {
        int tituloLength = titulo.Length;
        string style = string.Empty.PadLeft(tituloLength, '=');

        Console.Clear();
        Console.WriteLine(style);
        Console.WriteLine(titulo);
        Console.WriteLine(style + '\n');
    }

    public virtual void Executar(List<Banda> bandas)
    {
        Console.Clear();
    }
}
