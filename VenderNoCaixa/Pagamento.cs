using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public abstract class Pagamento
    {
        protected DateTime data;
        protected double total;


        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public Pagamento(double total)
        {
            if (total < 0)
                throw new ArgumentException("O valor do pagamento não pode ser negativo.", nameof(total));
            this.total = total;
            Data = DateTime.Now;
        }
        public abstract void RealizarPagamento();
    }
}