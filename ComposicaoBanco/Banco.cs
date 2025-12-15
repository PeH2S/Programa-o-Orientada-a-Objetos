using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        public List<Poupanca> Poupanca { get; set; }
        public List<ContaCorrente> Contas { get; set; }


        public Banco()
        {   
            Poupanca = new List<Poupanca>();
            Contas = new List<ContaCorrente>();
        }
       public void IniciarBanco()
        {
            Console.WriteLine("Banco iniciado com sucesso! Pronto para operações.");
        }

        // Método para abrir uma conta corrente
        public void AbrirConta(double saldoInicial, bool chequeEspecial)
        {
            ContaCorrente novaConta = new ContaCorrente(saldoInicial, chequeEspecial);
            Contas.Add(novaConta);
            Console.WriteLine("Conta corrente aberta com sucesso.");
        }

        // Método para abrir uma conta poupança
        public void AbrirPoupanca(double saldoInicial)
        {
            Poupanca novaPoupanca = new Poupanca(saldoInicial);
            Poupanca.Add(novaPoupanca);
            Console.WriteLine("Conta poupança aberta com sucesso.");
        }

        // Método para decretar falência e remover todas as contas
        public void DecretarFalencia()
        {
            Contas.Clear();
            Poupanca.Clear();
            Console.WriteLine("Banco decretou falência. Todas as contas foram removidas.");
        }
    }
}