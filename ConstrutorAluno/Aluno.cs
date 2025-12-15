using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        public string Nome { get; set; }
        public long Matricula { get; private set; }
        
        // Atributo estático para manter o padrão e o contador de matrículas
        private static long contador = 3000;
        private const long PadraoFatec = 157048231; // Parte fixa da matrícula
        

        public Aluno()
        {
            
        }
        public Aluno(string nome)
        {
            this.Nome = nome;
            this.Matricula = GerarMatricula();
        }

        
        private long GerarMatricula()
        {
            return PadraoFatec * 10000 + contador++;
        }

    
        public void Mostrar()
        {
            Console.WriteLine($"Nome: {Nome} \tMatrícula: {Matricula}");
        }

      
    }
}