
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

Console.WriteLine("Instruções break e Continue");

//Instrução break:
for (; ; )
{
    Console.WriteLine("Tecle algo() x sai");
    var opcao = Console.ReadLine();
    Console.WriteLine(opcao.ToUpper());

    if (opcao == "x" || opcao == "x")
    {
        Console.WriteLine("Tchau...");
        break;

    }

}

//Instrução continue:
for (int i = 1; i <= 10; i++)
{
    if (i == 4)
        continue;

    Console.WriteLine(i);

}

//Loop While:
int n = 1;
while (n <= 10)
{
    if (n == 5)
    {

        n++;
        continue;// sai do loop while

    }
    Console.WriteLine($"n={n}");
    n++;
}

//Usando break e continue:
for (int i = 1; i < 10; i++) 
{
    if (i == 5)
        continue;

    if (i == 8)
        break;

    Console.WriteLine(i);

}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();