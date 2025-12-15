using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public DateTime DataDeposito { get; set; }
        public int Situacao { get; set; }

        public Cheque(double total, long numero, DateTime dataDeposito, int situacao) : base(total)
        {
            this.Numero = numero;
            this.DataDeposito = dataDeposito;
            this.Situacao = situacao;
        }
        public override void RealizarPagamento()
        {
            Console.WriteLine($"Pagamento realizado por cheque no valor de {Total:C} (Número: {Numero})");
        }
    }
}