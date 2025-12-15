double a = 10, b = 0;



try
{
    double resultado = a / b;
    
}

catch (Exception e)
{
    Console.WriteLine();
    System.Console.WriteLine("Erro - divisão por zero");
    Console.WriteLine("Erro pelo Exception");Console.WriteLine("-------------------------------------");Console.WriteLine(e.ToString());Console.WriteLine();
}

System.Console.WriteLine("Término do programa");