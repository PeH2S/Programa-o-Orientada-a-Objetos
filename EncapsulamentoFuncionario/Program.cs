using EncapsulamentoFuncionario;

//Exemplo de encapsulamento mais detalhado e parecido com Java e PHP
/*
Funcionario f1 = new Funcionario();
f1.setCodigo(1);
System.Console.WriteLine($"Codigo: {f1.getCodigo()}");
*/

Funcionario f1 = new Funcionario();
f1.Codigo = 1; // Aqui é executado o método set
System.Console.WriteLine($"Codigo: {f1.Codigo}"); //Aqui chama o get
f1.Nome = "João";
System.Console.WriteLine($"Nome: {f1.Nome}");
f1.Salario = 2000;
System.Console.WriteLine($"Salario: {f1.Salario:c}");
//if (f1.Codigo == 3)