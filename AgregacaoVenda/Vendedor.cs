using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public decimal Comissao { get; set; }

        public Vendedor()
        {
            Nome = string.Empty; // Inicializa o nome como vazio
            Comissao = 0; // Inicializa a comissão como 0
        }

        public Vendedor(string nome)
        {
            Nome = nome;
            Comissao = 0;
        }
    }
}