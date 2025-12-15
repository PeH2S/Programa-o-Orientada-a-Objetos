using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; } 
        public decimal Preco { get; set; }
        public int Qtde { get; set; }

        //Criar 3 construtores
        public Produto(int codigo, string nome, decimal preco, int qtde)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
            this.Qtde = qtde;
        }

        //Criar Metodo MostrarAtributos()
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tPreço: {Preco:c} \tQuantidade: {Qtde}");
        }
    }
}