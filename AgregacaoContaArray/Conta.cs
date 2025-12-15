using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaArray
{
    public class Conta
    {
        public int Numero { get; set; }
        //Relacionamento entre classes, por meio do atributo titular
        
        public List<Cliente> Titular { get; set; }
        public double Saldo { get; set; }
        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Número: {Numero} \tSaldo: {Saldo}");
        }
    }
}