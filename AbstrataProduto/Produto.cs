using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataProduto
{
    public abstract class Produto
    {
        protected int codigo;
        protected double preco;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public Produto(int codigo, double preco)
        {
            this.Codigo = codigo;
            this.Preco = preco;
        }

        public virtual void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo} \tPreço: {Preco}");
        }
        public abstract void AtualizarPreco(double preco);
    }
}