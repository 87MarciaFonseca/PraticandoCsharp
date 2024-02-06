
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

/*//Multiplas interações em um loop for.

for (int i = 0,j = 0; i +j <= 20; i++,j++)
{
    Console.WriteLine( $"i = {i} e j ={j}");

}
*/

//Loop For aninhado
for (int x= 0; x<5; x++) 
{
    for (int y = 0; y < 5; y++) 
    {
        Console.Write($"{x},{y}  ");


    }
    Console.WriteLine();
}





Console.WriteLine( "\nFim do processamento");
Console.ReadKey();