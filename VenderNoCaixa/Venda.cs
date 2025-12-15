using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Venda
    {
        public DateTime Data { get; set; }
        public double Total { get; private set; }
        public List<ItemVenda> Itens { get; set; }

        public Venda(DateTime data)
        {
            Itens = new List<ItemVenda>();
            this.Data = data;
        }
        public void CalcularTotal()
        {
            Total = 0;
            foreach (var item in Itens)
            {
                item.CalcularSubtotal();
                Total += item.Subtotal;
            }

            int totalProdutos = 0;
            foreach (var item in Itens)
            {
                totalProdutos += item.Quantidade;
            }

            if (totalProdutos > 50)
            {
                Total *= 0.8; // Aplica 20% de desconto
            }
        }
    }
}