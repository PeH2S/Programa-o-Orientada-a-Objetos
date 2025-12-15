using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private static int contador = 500;
        private decimal preco;

        public int Codigo { get; private set; }
        public string Nome { get; set; }

        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
            }
        }

        public Produto()
        {
            Nome = string.Empty;
            Preco = 0; // Inicializa com preço 0.
        }

        public Produto(string nome, decimal preco)
        {
            Codigo = contador++;
            Nome = nome;

            if (preco >= 0)
            {
                Preco = preco;
            }
            else
            {
                Preco = 0; // Se o preço for negativo, inicializa como 0.
            }
        }
    }
}