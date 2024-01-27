Console.WriteLine("Instrução while 2");
//While com break-Exemplo: Usando break em um laço while
/*while (true)
{

    Console.WriteLine("\nInforme um numero inteiro: (Para sair tecle 999)"  );
    int numero = Convert.ToInt32( Console.ReadLine() );

    if (numero == 999)// código para acionar o break
    {
        break;
    }
    if (numero % 2 == 0)
        Console.WriteLine($"{numero} é PAR ");
   else
        Console.WriteLine($"{numero} é IMPAR ");
}*/

//While aninhadas-Exemplo: coordenadas do plano (x,y)
int x = 0;

while (x<5)//1- loop while
{
    int y=0;
    while (y<5)//2 - loop while,será excutado enquanto y<5
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
   x++;
   Console.WriteLine();
}

Console.WriteLine("\n Fim do processamento...");
Console.ReadKey();

