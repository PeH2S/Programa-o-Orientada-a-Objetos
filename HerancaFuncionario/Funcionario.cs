using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double TotaldeBonificacao { get; private set; }
        

        public Funcionario()
        {

        }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            TotaldeBonificacao = 0;
        }

        public virtual void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tSalario: {Salario:c}");
        }
        public virtual double CalcularBonificacao()
        {
            return Salario * 10/ 100;
        }
        public void TotalizadorBonificacao(){ 
            this.TotaldeBonificacao += CalcularBonificacao();
        }
        public void MostrarBonificacao()
    {
        Console.WriteLine($"Total da Bonificação: {TotaldeBonificacao:c}"); 
    }
    }
}