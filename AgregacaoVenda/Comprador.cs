using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private decimal verba;

        public decimal Verba
        {
            get { return verba; }
            set
            {
                if (value >= 0)
                {
                    verba = value;
                }
                else
                {
                    verba = 0; // Se a verba for negativa, inicializa como 0
                }
            }
        }

        public Comprador()
        {
            Verba = 0; // Inicializa com verba 0
        }

        public Comprador(decimal verbaInicial)
        {
            if (verbaInicial >= 0)
            {
                Verba = verbaInicial;
            }
            else
            {
                Verba = 0; // Se a verba inicial for negativa, inicializa como 0.
            }
        }

        public void SubtrairVerba(decimal valor)
        {
            if (valor <= Verba)
            {
                Verba -= valor;
            }
        }
    }
}