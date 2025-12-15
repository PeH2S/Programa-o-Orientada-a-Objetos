// Método Main

using AgregacaoConta;

Cliente cli1 = new Cliente("Ana", 1234);

Conta c1 = new Conta(1, 100);
c1.Titular = cli1; // agregação acontece agora

System.Console.WriteLine($"Número: {c1.Numero} \tTitular - Nome: {c1.Titular.Nome} \tTitular - RG: {c1.Titular.Rg} \tSaldo: {c1.Saldo}");


Conta c2 = new Conta(2, 200);
c2.Titular = new Cliente();
c2.Titular.Nome = "Bia";
c2.Titular.Rg = 4321;

System.Console.WriteLine($"Número: {c2.Numero} \tTitular - Nome: {c2.Titular.Nome} \tTitular - RG: {c2.Titular.Rg} \tSaldo: {c2.Saldo}");