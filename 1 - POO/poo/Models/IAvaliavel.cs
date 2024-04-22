namespace poo;

internal interface IAvaliavel
{
    double Media { get; }
    
    void AddAvaliacao(Avaliacao avaliacao);
    int qtdAvaliacoes();
}
