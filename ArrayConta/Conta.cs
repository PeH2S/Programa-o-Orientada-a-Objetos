using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta

{
    public class Conta
    {
        // Declaração de atributos
        public int numero;
        public string titular;
        public double saldo;

        // Declaração dos métodos
        public void Sacar()
        {
            
        }
        public void Depositar()
        {

        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo: {saldo:c}");
           
        }

    }
}