// Método Main

using AgregacaoContaArray;

Cliente cli1 = new Cliente("Ana", 100);
Cliente cli2 = new Cliente("João", 350);
Cliente cli3 = new Cliente("Beto", 150);

Conta c1 = new Conta(1, 10000);
c1.Titular = new List<Cliente>();
c1.Titular.Add(cli1);
c1.Titular.Add(cli2);
c1.Titular.Add(cli3);

System.Console.WriteLine("..............Apresentação da Conta.................");
c1.MostrarAtributos();
foreach (Cliente c in c1.Titular)
    c.MostrarAtributos();