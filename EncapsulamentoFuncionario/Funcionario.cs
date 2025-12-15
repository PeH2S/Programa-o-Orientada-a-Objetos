using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        // Declaração dos atributos
        private int codigo;
        private string nome;
        private double salario;
        private int porcentagem;

        // Declaração de métodos

        //Métodos de encapsulamento get e set
        /*
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return this.codigo;
        }
        */
        public int Codigo{ //Propriedade
            set {
                this.codigo = value; // Esse value, recebe qualquer tipo de valor
            }            
            get{
                return this.codigo;
            }
        }
        public string Nome{
            set{
                this.nome = value;
            }
            get{
                return this.nome;
            }
        }
        public double Salario{
            set{
                this.salario = value;
            }
            get{
                return this.salario;
            }
        }
        
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Esse funcionário recebe R$100,00 \tCódigo: {codigo} \tNome: {nome} \tSalario: {salario:c}");
        }

        // Criar um método para aplicar uma porcentagem de aumento ao salário
        private void AumentarSalario(int salario)
        {
            salario += salario * porcentagem / 100;
            System.Console.WriteLine("Salário com aumento: R$" + salario);
        }
    }
}