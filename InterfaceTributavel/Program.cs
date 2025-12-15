using InterfaceTributavel;

ContaCorrente conta = new ContaCorrente(1000.00);
Console.WriteLine($"Saldo da Conta Corrente: R$ {conta.Saldo:F2}");
Console.WriteLine($"Imposto da Conta Corrente: R$ {conta.CalcularTributos():F2}");

SeguroDeVida seguro = new SeguroDeVida();
Console.WriteLine("\nSeguro de Vida:");
Console.WriteLine($"Imposto do Seguro de Vida: R$ {seguro.CalcularTributos():F2}");

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
totalizador.Adiciona(conta);
totalizador.Adiciona(seguro);

Console.WriteLine($"\nTotal de Tributos Calculados: R$ {totalizador.Total:F2}");
