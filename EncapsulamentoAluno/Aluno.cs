using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media { get; private set; }

        //Declaração dos métodos
        public void CalcularMedia()
        {
            Media = (P1 + P2) / 2;
        }
        //Método Mostrar
        public void Mostrar()
        {
            System.Console.WriteLine($"Matricula: {Matricula} \tNome: {Nome} \tP1: {P1:n} \tP2: {P2:n} \tMédia: {Media:n}");
        }
    }
}