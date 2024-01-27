
using System.Diagnostics.SymbolStore;
using System.Text.Encodings.Web;

Console.WriteLine("Instrução While");

//Exemplo usando método de incremento 

var i = 1;
while (i < 10)//condição do laço while
{
    Console.WriteLine($"i = {i}");
    i++;// tem incrementar ou descrementar para evitar loop infinito

}



//Exemplo usando método de descremento

var i = 10;
while (i > 0)//condição while 
{
    Console.WriteLine($"i = {i}");
    i--;//usando o decremento p/ evitar loop infinito

}


//Exemplo:Imprimir a tabuada de um número maior que zero
int numero;
int contador = 1;
Console.WriteLine( "\nDigite um numero maior que zero\t");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0) 
{
    //loop while
    Console.WriteLine( $"\n Tabuada do {numero}\n");
    while(contador < 11)
    {

        Console.WriteLine($"{numero}x {contador} = {numero * contador}");
        contador++;
  
    }
}
else
{

    Console.WriteLine("\nNúmero deve ser maior que zero !!");
}
 
Console.WriteLine("\nFim do processsamento..");
Console.ReadKey();