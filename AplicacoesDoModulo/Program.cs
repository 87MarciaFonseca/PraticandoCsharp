
using System.ComponentModel.Design;

Console.WriteLine("\nAplicações das estruturas de repetição");
int  num1,num2,num3;

Console.WriteLine("\nEncontre um valor dentre os 3 números");


Console.WriteLine("\n Primeiro número\t");
num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("\nSegundo número\t");
num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("\nTerceiro número");
num3 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2)
{
    if (num1 > num3)
        Console.Write($" O Primeiro número{num1} é maior.\n");

    else

        Console.Write($" O Terceiro núemro (num3) é o maior.\n");

}

else if (num2 > num3)


    Console.Write($"O Segundo número {num2} é maior.\n");
else

    Console.WriteLine($"O terceiro númuero {num3} é o maior.\n");



Console.WriteLine("\nFim do processamento...");
Console.ReadKey( );