
using ComposicaoBanco;


Banco b1 = new Banco();

// Criando instâncias de Poupança com saldo inicial
Poupanca po1 = new Poupanca(2000.00);
Poupanca po2 = new Poupanca(3000.00);

// Criando instâncias de ContaCorrente com saldo inicial e indicação de cheque especial
ContaCorrente c1 = new ContaCorrente(1000.00, true);
ContaCorrente c2 = new ContaCorrente(1500.00, false);


b1.Poupanca.Add(po1);
b1.Poupanca.Add(po2);


b1.Contas.Add(c1);
b1.Contas.Add(c2);

c1.MostrarAtributos();
c2.MostrarAtributos();

c1.GerarExtrato();
c2.GerarExtrato();

po1.GerarExtrato();
po2.GerarExtrato();