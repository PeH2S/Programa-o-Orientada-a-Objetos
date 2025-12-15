using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Especie : Pagamento
    {
        public double Quantia { get; set; }
        public double Troco => Quantia - Total; // Calcula o troco com base na quantia paga

        public Especie(double total, double quantia) : base(total)
        {
            Quantia = quantia;
        }
        public override void RealizarPagamento()
        {
            Console.Write("Digite o valor pago em espécie: ");
            Quantia = double.Parse(Console.ReadLine());

            if (Quantia < Total)
            {
                Console.WriteLine("Valor insuficiente para o pagamento.");
            }
            else
            {
                Console.WriteLine($"Pagamento realizado em espécie no valor de {Total:C}");
                Console.WriteLine($"Troco: {Troco:C}");
            }
        }
    }
}