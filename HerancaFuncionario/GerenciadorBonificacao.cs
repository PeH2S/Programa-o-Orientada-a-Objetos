using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class GerenciadorBonificacao
    {
        public double TotaldeBonificacao { get; private set; }

        //Polimorfismo Estatico, faz as alterações dentro da propria classe
        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.TotaldeBonificacao += funcionario.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Secretario secretario)
        {
            this.TotaldeBonificacao += secretario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Gerente gerente)
        {
            this.TotaldeBonificacao += gerente.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretor diretor)
        {
            this.TotaldeBonificacao += diretor.CalcularBonificacao();
        }
        public void MostrarBonificacoes(List<Funcionario> funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                funcionario.MostrarAtributos();
                funcionario.MostrarBonificacao();
            }

            Console.WriteLine($"Total Geral de Bonificações: {TotaldeBonificacao:c}"); // Nome correto
        }
    }
}


