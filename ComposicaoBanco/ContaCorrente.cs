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

        public static int Contador{
            get{ return contador; }
        }

        // Declaração dos métodos

        public ContaCorrente()
        {
            //Construtor padrão
            contador++;
        }
        public ContaCorrente(double saldo, bool chequeEspecial)
        {
            this.Saldo = saldo;
            this.ChequeEspecial = chequeEspecial;   
        }
        public void Depositar(){}
        public void Sacar(){}
        public void GerarExtrato(){}
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo: {saldo:c}");
        }
        
    }
}
