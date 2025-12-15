using Produto-1;

ClasseProduto n1 = new ClasseProduto();

System.Console.Write("Digite o nome do Produto: ");
n1.nome = Console.ReadLine();
System.Console.Write("Digite o preço do Produto: ");
n1.preco = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Digite a quantidade em Estoque: ");
n1.qtd = Convert.ToInt32(Console.ReadLine());

n1.AdicionarProduto(10);
n1.Mostrar();
System.Console.WriteLine($"Valor total: {n1.ValorTotalEstoque():c}");
