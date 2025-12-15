using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Cartao : Pagamento
    {
        public string DadosTrasacao { get; set; }
        public int ResultadoTrasacao { get; set; }

        public Cartao(double total, string dadosTrasacao, int resultadoTrasacao) : base(total)
        {
            this.DadosTrasacao = dadosTrasacao;
            this.ResultadoTrasacao = resultadoTrasacao;
        }

        public override void RealizarPagamento()
        {
            Console.WriteLine($"Pagamento realizado por cartão no valor de {Total:C} (Dados da transação: {DadosTrasacao}, Resultado da transação: {ResultadoTrasacao})");
        }
    }
}