using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        public ContaCorrente Saldo { get; set; }

        public Poupanca(ContaCorrente saldo)
        {
            this.Saldo = saldo;
        }
        public void Depositar(){}
        public void Sacar(){}
        public void GerarExtrato(){}
    }
}