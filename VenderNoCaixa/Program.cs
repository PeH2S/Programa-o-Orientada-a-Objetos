using VenderNoCaixa;

public class Program
{
    static List<Produto> produtos = new List<Produto>();
    static Venda venda;

    public static void Main()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("Sistema de Vendas");
            Console.WriteLine("1 - Cadastrar Produto");
            Console.WriteLine("2 - Realizar Venda");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarProduto();
                    break;
                case 2:
                    RealizarVenda();
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        } while (opcao != 3);
    }

    private static void CadastrarProduto()
    {
        Console.Clear();
        Console.WriteLine("Cadastro de Produto");

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Estoque: ");
        int estoque = int.Parse(Console.ReadLine());

        Produto produto = new Produto(codigo, nome, preco, estoque);
        produtos.Add(produto);

        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    private static void RealizarVenda()
    {
        Console.Clear();
        Console.WriteLine("Iniciando Venda");

        venda = new Venda(DateTime.Now);
        int opcaoProduto;

        do
        {
            Console.WriteLine("Escolha um produto para adicionar à venda:");
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {produtos[i].Nome} - R${produtos[i].Preco} - Estoque: {produtos[i].Estoque}");
            }

            Console.WriteLine("0 - Finalizar Venda");
            Console.Write("Escolha um produto (0 para finalizar): ");
            opcaoProduto = int.Parse(Console.ReadLine());

            if (opcaoProduto > 0 && opcaoProduto <= produtos.Count)
            {
                Produto produtoSelecionado = produtos[opcaoProduto - 1];

                Console.Write($"Quantidade de {produtoSelecionado.Nome}: ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade > produtoSelecionado.Estoque)
                {
                    Console.WriteLine("Quantidade maior que o estoque disponível.");
                }
                else
                {
                    ItemVenda itemVenda = new ItemVenda(quantidade, produtoSelecionado);
                    venda.Itens.Add(itemVenda);

                    produtoSelecionado.Estoque -= quantidade;

                    Console.WriteLine($"Produto {produtoSelecionado.Nome} adicionado à venda.");
                }
            }
            else if (opcaoProduto == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Produto inválido.");
            }

        } while (opcaoProduto != 0);

        venda.CalcularTotal();
        Console.WriteLine($"Total da Venda: {venda.Total:C}");

        RealizarPagamento();
    }

    private static void RealizarPagamento()
    {
        Console.Clear();
        Console.WriteLine("Escolha a forma de pagamento:");

        Console.WriteLine("1 - Espécie");
        Console.WriteLine("2 - Cheque");
        Console.WriteLine("3 - Cartão");
        Console.Write("Escolha uma opção: ");
        int opcaoPagamento = int.Parse(Console.ReadLine());

        Pagamento pagamento = null;

        switch (opcaoPagamento)
        {
            case 1:
                pagamento = new Especie(venda.Total, 10.0);
                pagamento.RealizarPagamento();
                break;
            case 2:
                Console.Write("Número do Cheque: ");
                long numeroCheque = long.Parse(Console.ReadLine());
                Console.Write("Data do Depósito (dd/MM/yyyy): ");
                DateTime dataDeposito = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                pagamento = new Cheque(venda.Total, numeroCheque, dataDeposito, 1);
                pagamento.RealizarPagamento();
                break;
            case 3:
                Console.Write("Dados da Transação: ");
                string dadosTransacao = Console.ReadLine();
                pagamento = new Cartao(venda.Total, "Dados de transação do Cartão", 1);
                pagamento.RealizarPagamento();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        Console.WriteLine("Pagamento realizado com sucesso!");
    }
}
