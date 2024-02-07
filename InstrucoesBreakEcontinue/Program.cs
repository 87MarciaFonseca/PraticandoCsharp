
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

Console.WriteLine("Instruções break e Continue");

/*//Instrução break:
for (; ; )//laço for infinito
{
    Console.WriteLine("Tecle algo (x sai)");
    var opcao = Console.ReadLine();// receber informação via teclado
    Console.WriteLine(opcao.ToUpper());//transforma o texto  p/ caixa alta

    if (opcao == "X" || opcao == "x")//condição
    {
        Console.WriteLine("Tchau...");
        break;// comnando p/ sair sair do loop

    }

}*/

/*//Instrução continue:
for *//*(int i = 1; i <= 10; i++)
{
    if (i == 4)//condição
        continue;// comando p/ sair do loop

    Console.WriteLine(i);

}*/

//Loop While:
int n = 1;
while (n <= 10)
{
    if (n == 5)// se operação não for verdade,ele vai continuar o loop até 4 e depois incrementa
    {

        n = n + 1;
        continue;// sai do loop while

    }
    Console.WriteLine($"n={n}");
    n++;
}

/*//Usando break e continue:
for (int i = 1; i < 10; i++)
{
    if (i == 5)
        continue;

    if (i == 8)
        break;

    Console.WriteLine(i);

}*/

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();