using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Dependente(int codigo, string nome, int idade) 
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Idade = idade;
        }
        public bool VerificarMaiorIdade(int idade)
        {
            if (idade >= 18)
                return true;
            else
                return false;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Dependente: {Nome}, Idade: {Idade}");
        }
    }
}