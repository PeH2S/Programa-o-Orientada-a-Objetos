using HerancaProduto;

Produto p1 = new Produto();
p1.Codigo = 0;
p1.Nome = "Maquita";
p1.Preco = 100;
p1.Mostrar();

Produto p2 = new Produto(1, "Lápis", 5.50);

Perecivel pere1 = new Perecivel();
pere1.Codigo = 0;
pere1.Nome = "Tilápia";
pere1.Preco = 45.5;
pere1.DtFabricacao = "10/02/2024";
pere1.DtValidade = "10/04/2024";
pere1.Lote = 0;

pere1.Mostrar();