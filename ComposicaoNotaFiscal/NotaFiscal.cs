using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNota { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetItemNotaFiscal { get; set; }


        public NotaFiscal(string data, int numeroNota)
        {
            this.Data = data;
            this.NumeroNota = numeroNota;
            // A composição acontece agora, pois os objetos nota fiscal e vetor de itens são instanciados juntos.
            VetItemNotaFiscal = new List<ItemNotaFiscal>();
        }
        ~NotaFiscal(){
            VetItemNotaFiscal = null;
            System.Console.WriteLine("Destruir a Nota fiscal");
        }
    }
}