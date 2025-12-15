//Método Main()
using ArrayConta;

//Declarar o vetor de objetos
Conta[] vetContas = new Conta[3];

//Manipular o vetor
for (int i = 0; i < vetContas.Length; i++)
{
    vetContas[i] = new Conta();
    Console.Write("Cadastre o número: ");
    vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Cadastre o titular: ");
    vetContas[i].titular = Console.ReadLine();
    Console.Write("Cadastre o saldo: ");
    vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("");
}
foreach (Conta c in vetContas)
    c.MostrarAtributos();