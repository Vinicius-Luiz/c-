using classe_heranca;

#region MOTOCICLETA
Console.Clear();
Motocicleta motoHenrique = new(marca: "Honda", modelo: "XRE", ano: 2022, cilindrada: 650);
motoHenrique.ExibirDetalhes();
#endregion

#region FUNCIONARIO
Console.Clear();
Desenvolvedor funcVinicius = new(nome: "Vinicius", departamento: "TI Integração");
funcVinicius.Trabalhar();
Analista funcLuis = new(nome: "Luis", departamento: "se tomar no cu");
funcLuis.Trabalhar();
#endregion