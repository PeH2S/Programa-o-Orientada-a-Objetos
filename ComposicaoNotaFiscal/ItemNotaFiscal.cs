using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int Qtde { get; set; }   
        public ItemNotaFiscal(int qtde)
        {
            this.Qtde = qtde;
        }
        ~ItemNotaFiscal(){ // Destrutor da classe
            System.Console.WriteLine("Destruir item nota fiscal");
        }
    }
}