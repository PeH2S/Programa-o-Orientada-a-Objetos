using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Comissionado : Funcionario
    {
        private double comissao = 0.20;

        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }

        public Comissionado(int codigo, string nome, double salario, double comissao) : base(codigo, nome, salario, new List<Dependente>())
        {
            this.Comissao = comissao;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            System.Console.WriteLine($"Comissão: {Comissao}");
        }

        public override double CalcularSalario(int diasUteis)
        {
            return ((Salario / 30 * diasUteis) * comissao + Salario);
        }

        public override void AdicionarDependente(Dependente dependente)
        {
            Dependentes.Add(dependente);  // Adicionando o dependente corretamente
            Console.WriteLine($"Dependente {dependente.Nome} adicionado ao funcionário {Nome}.");
        }

        public override void RemoverDependente(int codigo)
        {
            for (int i = Dependentes.Count - 1; i >= 0; i--)
            {
                Dependente d = Dependentes.ElementAt(i);
                if (d.Codigo == codigo)
                {
                    Dependentes.Remove(d);
                    Console.WriteLine($"Dependente {d.Nome} removido.");
                    return;
                }
            }
        }
        public override int CalcularTotalDependentes()
        {
            return Dependentes.Count;
        }

        public override void ListarDependentes()
        {
            Console.WriteLine($"Dependentes do funcionário {Nome}:");
            foreach (var dependente in Dependentes)
            {
                Console.WriteLine($"Nome: {dependente.Nome}, Idade: {dependente.Idade}");
            }
        }
    }

}