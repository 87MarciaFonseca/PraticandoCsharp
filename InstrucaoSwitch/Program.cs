 
Console.WriteLine("Instrução Switch");
Console.WriteLine("Valor da compra R$600,00\n");
Console.WriteLine("Informe o numero de parcelas (1 à 3");
var numeroParcelas= Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
 case 1:
    Console.WriteLine($"\nPrestação R${600 / numeroParcelas}");
 break;

 case 2:

    Console.WriteLine($"\nPrestação R${600/numeroParcelas}");
  break;

 case 3:

 Console.WriteLine($"\nPrestação R${600 / numeroParcelas}");
   break;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey( );