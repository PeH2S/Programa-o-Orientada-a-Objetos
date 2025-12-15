using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Vendedor Vendedor { get; set; }
        public Comprador Comprador { get; set; }
        public List<Produto> Produtos { get; set; }

        public Venda()
        {
            Produtos = new List<Produto>();
        }

        public Venda(Vendedor vendedor, Comprador comprador)
        {
            Vendedor = vendedor;
            Comprador = comprador;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            if (produto != null)
            {
                Produtos.Add(produto);
                Comprador.SubtrairVerba(produto.Preco);
            }
        }

        public void FinalizarVenda()
        {
            foreach (var produto in Produtos)
            {
                Vendedor.Comissao += produto.Preco * 0.02m;
            }
        }
    }
}