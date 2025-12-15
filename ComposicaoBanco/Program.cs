
using ComposicaoBanco;

Poupanca po1 = new Poups(2000);
Poupanca po2 = new Poups(3000);

ContaCorrente c1 = new Contas(0);
ContaCorrente c2 = new Contas(1);

Banco b1 = new Banco();
b1.Poups.Add(po1);
b1.Poups.Add(po2);
b1.Contas.Add(c1);
b1.Contas.Add(c2);