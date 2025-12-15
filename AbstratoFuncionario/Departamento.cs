using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        private int codigo;
        private string descricao;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            VetF = new List<Funcionario>();
        }
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo}\tDescrição: {Descricao}");
        }
        public void Admitir(Funcionario novoFun)
        {
            VetF.Add(novoFun);
            Console.WriteLine($"Funcionário {novoFun.Nome} admitido no departamento {Descricao}.");
        }
        public void Listar()
        {
            MostrarAtributos();
            foreach(Funcionario f in VetF)
                f.MostrarAtributos();
        }

        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                    VetF.Remove(f);
            }
        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }
    }
}