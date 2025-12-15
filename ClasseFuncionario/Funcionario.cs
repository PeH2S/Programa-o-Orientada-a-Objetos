using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        // Declaração dos atributos
        public int codigo;
        public string nome;
        public double salario;
        public int porcentagem;

        // Declaração de métodos
        public void MostrarAtributos()
        {
            System.Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tSalário: R$" + salario);
        }

        // Criar um método para aplicar uma porcentagem de aumento ao salário
        public void AumentarSalario(int porcentagem)
        {
            salario += salario * porcentagem / 100;
            System.Console.WriteLine("Salário com aumento: R$" + salario);
        }
    }
}