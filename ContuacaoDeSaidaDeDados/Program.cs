using System.Collections.Specialized;

Console.WriteLine( "Continuaçao de Saída de Dados: Usando sequencia de escapes\n");
Console.WriteLine( );

string local = "c: \\dados\\poesias.txt";
string frase = "Ele falou:\"Te amo pandinha \"";

string pizza = "\nPizza\nde\tChocolate";

string bolo = "\nBolo\tde\tChocolate";

Console.WriteLine( local);
Console.WriteLine(frase );
Console.WriteLine(pizza );
Console.WriteLine(bolo );

Console.ReadLine( );