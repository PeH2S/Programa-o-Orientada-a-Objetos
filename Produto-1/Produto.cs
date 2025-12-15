using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto-1
{
    public class ClasseProduto
    {
        
        public string nome;
        public double preco;
        public int qtd;

        public void Mostrar()
        {
            System.Console.WriteLine("Nome: " + nome + "\tPreço: " + preco + "\tQuantidade: " + qtd);
        }
        public void AdicionarProduto(int qtd)
        {
            qtd += qtd;
        }
        public void RemoverProduto(int qtd)
        {
            qtd -= qtd;
        }
        public double ValorTotalEstoque()
        {
            return preco * qtd;
        }
    }
}