
using System.ComponentModel.Design;

Console.WriteLine("\nAplicações das Estruturas de controle e Repetição");

/*//Programa p/ receber 3 números e a seguir calcular e exibir qual é o maior
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
*/
//Programa p/ calcular a raiz da equação quadrática: ax^2 + bx + c= 0

int a, b, c;
double d, x1, x2;
Console.Write("Cálculo da equação do segundo grau :\n");
Console.Write("Informe o valor de a :\t ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de b :\t ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de c :\t ");
c = Convert.ToInt32(Console.ReadLine());
d = b * b - 4 * a * c;
if (d == 0)
{
    Console.Write("As duas raízes são iguais.\n");
    x1 = -b / (2.0 * a);
    x2 = x1;
    Console.Write($"Primeira raiz x1= {x1}\n");
    Console.Write($"Segunda raiz x2= {x2}\n");
}
else if (d > 0)
{
    Console.Write("Ambas as raízes são reais e diferentes\n");
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.Write($"Primeira raiz x1= {x1}\n");
    Console.Write($"Segunda raiz x2= {x2}\n");
}
else
    Console.Write("As raízes são imaginárias;\n Sem solução para os números reais. \n\n");

Console.WriteLine("\nFim do processamento...");
Console.ReadKey( );