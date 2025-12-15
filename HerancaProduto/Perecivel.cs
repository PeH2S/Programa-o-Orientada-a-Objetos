using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        public string DtValidade { get; set; }   
        public string DtFabricacao{ get; set; }
        public int Lote { get; set; }

        public Perecivel() : base()
        {
            
        }
        public Perecivel(int codigo, string nome, double preco, string dtValidade, string dtFabricacao, int lote) : base(codigo, nome, preco)
        {
            this.DtValidade = dtValidade;
            this.DtValidade = dtValidade;
            this.Lote = lote;
        }
        public void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine($"Lote: {Lote} \tData de Fabricação: {DtFabricacao} \tData de Validade: {DtValidade}");
        }
    }
}