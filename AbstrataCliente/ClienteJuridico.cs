using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
        public ClienteJuridico(int codigo, string nome, int idade, int cnpj) : base(codigo, nome, idade)
        {
            Cnpj = cnpj;            
        }
        public override void VerificaIdade()
        {
            if (Idade >= 46)
                System.Console.WriteLine("Cliente Juridico");
        }
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine($"CNPJ: {Cnpj}");
        }
    }
}