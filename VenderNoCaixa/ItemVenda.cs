using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class ItemVenda
    {
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public double Preco { get; }
        public double Subtotal => Produto.Preco * Quantidade;

        public ItemVenda(int quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
        }

        public double CalcularSubtotal()
        {
            return Produto.Preco * Quantidade;
        }
    }
}