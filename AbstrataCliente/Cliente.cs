using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {
        protected int codigo;
        protected string nome;
        protected int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public virtual void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tIdade: {Idade}");
        }
        public abstract void VerificaIdade(); // tem que terminar com ponto e virgula quando utilizamos abstract --> Assinatura de Método é saber se terá retorno, saber o nome / o que fará, saber se terá parâmetro.
        
    }
}