using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected double salario;
        protected List<Dependente> dependentes;
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
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public List<Dependente> Dependentes
        {
            get { return dependentes;}
            set { dependentes = value;}
        }
        
        public Funcionario(int codigo, string nome, double salario, List<Dependente> dependentes)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Salario = salario;
            this.Dependentes = new List<Dependente>();
        }

        public virtual void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalário: {Salario:c}");
            foreach (var dependente in Dependentes)
            {
                dependente.MostrarAtributos();
            }
        }
        public abstract double CalcularSalario(int diasUteis);
        public abstract int CalcularTotalDependentes();
        public abstract void AdicionarDependente(Dependente dependente);  
        public abstract void RemoverDependente(int codigo);               
        public abstract void ListarDependentes();
    }
}