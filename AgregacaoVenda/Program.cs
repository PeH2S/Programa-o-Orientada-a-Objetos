
using AgregacaoVenda;

// Criando vendedores e compradores
Vendedor vendedor1 = new Vendedor("João");
Comprador comprador1 = new Comprador(5700m);

// Criando produtos
Produto produto1 = new Produto("HD", 230m);
Produto produto2 = new Produto("SSD", 500m);
Produto produto3 = new Produto("Fonte", 500m);
Produto produto4 = new Produto("Pasta Termica", 120m);
Produto produto5 = new Produto("Gabinete", 500m);

// Criando uma venda
Venda venda1 = new Venda(vendedor1, comprador1);
venda1.AdicionarProduto(produto1);
venda1.AdicionarProduto(produto2);
venda1.AdicionarProduto(produto3);
venda1.AdicionarProduto(produto4);
venda1.AdicionarProduto(produto5);

// Finalizando a venda
venda1.FinalizarVenda();

// Exibindo resultados
Console.WriteLine($"Vendedor: {vendedor1.Nome}, Comissão: {vendedor1.Comissao}");
Console.WriteLine($"Comprador, Verba restante: {comprador1.Verba}");
