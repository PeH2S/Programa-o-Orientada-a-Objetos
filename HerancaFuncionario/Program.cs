using HerancaFuncionario;

// Criação de funcionários
Funcionario f = new Funcionario(1, "Ana", 1000);
f.MostrarAtributos();
System.Console.WriteLine($"Bonificação: {f.CalcularBonificacao():c}\n");

Secretario s = new Secretario(2, "Carlos", 4000);
s.MostrarAtributos();
System.Console.WriteLine($"Bonificação: {s.CalcularBonificacao():c}\n");

Gerente g = new Gerente(3, "Paulo", 5000);
g.MostrarAtributos();
System.Console.WriteLine($"Bonificação: {g.CalcularBonificacao():c}\n");

Diretor d = new Diretor(4, "Abel", 10000);
d.MostrarAtributos();
System.Console.WriteLine($"Bonificação: {d.CalcularBonificacao():c}\n");

// Gerenciador de bonificação
GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

// Acumulando bonificações
gerenciador.TotalizadorBonificacao(f);
gerenciador.TotalizadorBonificacao(s);
gerenciador.TotalizadorBonificacao(g);
gerenciador.TotalizadorBonificacao(d);



// Exibindo total de bonificações
System.Console.WriteLine($"Total de Bonificações: {gerenciador.TotaldeBonificacao:c}");


/*foreach (var funcionario in funcionarios)
{
    if (funcionario is Secretario secretario)
        gerenciador.TotalizadorBonificacao(secretario);
    else if (funcionario is Gerente gerente)
        gerenciador.TotalizadorBonificacao(gerente);
    else if (funcionario is Diretor diretor)
        gerenciador.TotalizadorBonificacao(diretor);
    else
        gerenciador.TotalizadorBonificacao(funcionario); // Para o Funcionario
}
*/