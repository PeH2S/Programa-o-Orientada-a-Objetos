//Função main

// Abre a comunicação 
using ClasseFuncionario;

// Instanciar objeto para conseguir cadastrar algo
Funcionario f1 = new Funcionario();
System.Console.Write("Digite o código: ");
f1.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Digite o nome: ");
f1.nome = Console.ReadLine();
System.Console.Write("Digite o salário: ");
f1.salario = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Digite a porcentagem de aumento: ");
f1.porcentagem = Convert.ToInt32((Console.ReadLine()));
f1.AumentarSalario(f1.porcentagem);
f1.MostrarAtributos(); // Enviando uma mensagem ao chamar um Método

System.Console.WriteLine();
Funcionario f2 = new Funcionario();
System.Console.Write("Digite o código: ");
f2.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Digite o nome: ");
f2.nome = Console.ReadLine();
System.Console.Write("Digite o salário: ");
f2.salario = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Digite a porcentagem de aumento: ");
f2.porcentagem = Convert.ToInt32((Console.ReadLine()));
f2.AumentarSalario(f2.porcentagem);
f2.MostrarAtributos(); // Enviando uma mensagem ao chamar um Método

double somaSalario = f1.salario + f2.salario;
