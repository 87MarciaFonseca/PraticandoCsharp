﻿Console.WriteLine("Instrução For");

//Loop for
/*for (int i = 0, j =0; i + j <= 20; i++, j++) 
{
    Console.WriteLine( $"i ={i} e j={j}");
    
}*/


for (int x = 0; x< 5; x++) 
{

    for (int y = 0; y < 5; y++) 
    {

        Console.Write($"({x},{y})  ");
    }
    Console.WriteLine();
}



Console.WriteLine("\nFim do processamento..." );
Console.ReadKey( );