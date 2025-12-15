using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Produto
    {
        protected int codigo;
        protected string nome;
        protected double preco;

        public int Codigo{
            get{ return this.codigo; }
            set{ this.codigo = value; }
        }
        public string Nome{
            get{ return this.nome; }
            set{ this.nome = value; }
        }
        public double Preco{
            get{ return this.preco;}
            set{ this.preco = value;}
        }

        public Produto()
        {
            
        }
        public Produto(int codigo, string nome, double preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
        public void Mostrar()
        {
            System.Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tPreço: {Preco}");
        }
    }
}