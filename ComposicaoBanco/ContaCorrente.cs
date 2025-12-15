using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        // Declaração de atributos
        public double Saldo { get; set; }
        public bool ChequeEspecial { get; set; }
        private static int contador;

        public static int Contador
        {
            get { return contador; }
        }

        // Declaração dos métodos

        public ContaCorrente()
        {
            // Construtor padrão
            contador++;
        }

        public ContaCorrente(double saldo, bool chequeEspecial)
        {
            this.Saldo = saldo;
            this.ChequeEspecial = chequeEspecial;
            contador++;
        }

        public double Depositar(double valor)
        {
            Saldo += valor; // Atualiza o saldo
            return Saldo;   // Retorna o saldo atualizado
        }

        public double Sacar(double valor)
        {
            if (Saldo <= 0)
            {
                Console.WriteLine("Saldo insuficiente!!");
                return Saldo; // Retorne o saldo atual
            }
            else if (Saldo >= valor)
            {
                Saldo -= valor;
                return Saldo; // Retorne o saldo atualizado
            }
            else
            {
                Console.WriteLine("Valor do saque maior que o saldo disponível!");
                return Saldo; // Retorne o saldo atual se o saque for maior que o saldo
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine("\n===== Extrato Conta Corrente =====");
            Console.WriteLine($"Saldo atual: {Saldo:C}");
            Console.WriteLine($"Cheque especial: {(ChequeEspecial ? "Ativo" : "Inativo")}");
            Console.WriteLine("==================================");
            System.Console.WriteLine("");
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Cheque Especial: {(ChequeEspecial ? "Ativo" : "Inativo")}");
        
        }
    }
}
