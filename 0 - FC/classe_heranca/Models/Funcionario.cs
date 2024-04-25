namespace classe_heranca
{
    public abstract class Funcionario
    {
        private string? NomeP { get; set; }
        private string? DepartamentoP { get; set; }
        public string? Nome { get { return NomeP; } set { NomeP = value; } }
        public string? Departamento { get { return DepartamentoP; } set { DepartamentoP = value; } }

        public Funcionario(string nome, string departamento){
            Nome = nome;
            Departamento = departamento;
        }
        public abstract void Trabalhar();

    }
}