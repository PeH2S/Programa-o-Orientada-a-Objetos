
using ComposicaoNotaFiscal;

ItemNotaFiscal it1 = new ItemNotaFiscal(10);
ItemNotaFiscal it2 = new ItemNotaFiscal(3);

NotaFiscal nf = new NotaFiscal("11/09/2024", 1);
nf.VetItemNotaFiscal.Add(it1);
nf.VetItemNotaFiscal.Add(it2);


nf = null; //Forçando a destruição da instância.
GC.Collect(); // Forçando a chamada do coletor de lixo e conseguentemente seu destrutor.