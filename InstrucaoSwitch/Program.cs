
Console.WriteLine("Instrução Switch 1 \t ");
//Exemplo número de prestações
/*int compra = 600;
Console.WriteLine("Valor da compra R$600,00\n");
Console.WriteLine( "Informe o n° de parcelas (1 à 3)\t");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas) 
{ 
  case 1:
    Console.WriteLine($"\nPrestação R${600 / numeroParcelas}");
     break;

  case 2: 
        
     Console .WriteLine($"\nPrestação R${600 / numeroParcelas}");
      break;

   case 3:
     Console.WriteLine($"\nPrestação R${600 / numeroParcelas}");
      break;
    default:

      Console.WriteLine("\nValor inválido,informe 1,2,3");
        break;

}
Console.WriteLine("\nFim do processamento...");
Console.ReadKey( );*/

//Avaliando o valor de uma expressão:Par Ímpar

Console.WriteLine("Informe número inteiro :\t");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine("\n" + numero + " é par");
        break;
    case 1:
        Console.WriteLine("\n" + numero + "impar");
        break;

}
Console.WriteLine("\nFim do processamento...");
Console.ReadKey(); 