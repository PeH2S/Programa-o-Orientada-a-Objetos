using HerancaFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
f.MostrarAtributos();
System.Console.WriteLine($"Bonificação {f.CalcularBonificacao():c}");

Secretario s = new Secretario(2, "Carlos", 4000);
s.MostrarAtributos();
System.Console.WriteLine($"Bonificação {s.CalcularBonificacao():c}");

Gerente g = new Gerente(3, "Paulo", 5000);
g.MostrarAtributos();
System.Console.WriteLine($"Bonificação {g.CalcularBonificacao():c}");

Diretor d = new Diretor(4, "Abel", 10000);
d.MostrarAtributos();
System.Console.WriteLine($"Bonificação {d.CalcularBonificacao():c}");