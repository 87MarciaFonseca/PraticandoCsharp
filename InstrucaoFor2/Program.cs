﻿
Console.WriteLine("Instrução For 2");


/*//loop for sem definir a inicialização  e am instrução de iteração

int i = 1;
for (; i <= 5;)
{
    Console.WriteLine($"Loop for: Iteração {i}");
    i++;

}


//Loop nenhuma seção (loop infinito)
int i = 1;
for (; ; ) 
{

    Console.WriteLine( $"Loop for: Iteração {i}");
    i++;
}*/

//Multiplas interações em um loop for

for (int i = 0,j = 0; i +j <= 20; i++,j++)
{
    Console.WriteLine( $"i = {i} e j ={j}");

}


Console.WriteLine( "\nFim do processamento");
Console.ReadKey();