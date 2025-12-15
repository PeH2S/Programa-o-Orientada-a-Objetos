using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        public double Saldo { get; private set; }

        // Construtor que recebe um saldo inicial
        public Poupanca(double saldoInicial)
        {
            this.Saldo = saldoInicial;
        }

       
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso. Saldo atual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        
        public void Sacar(double valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Saldo atual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");
            }
        }

        
        public void GerarExtrato()
        {
            Console.WriteLine("===== Extrato Conta Poupança =====");
            Console.WriteLine($"Saldo atual: {Saldo:C}");
            Console.WriteLine("==================================");
            System.Console.WriteLine("");
        }
    }
}