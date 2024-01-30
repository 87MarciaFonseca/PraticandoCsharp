Console.WriteLine("\n Instrução do-while");

//Imprimir o valor de uma variável i de 1 a 10.
var i = 1;
do
{
    Console.WriteLine($"i = {i}");
    i++;

}
while (i <= 10);//Enquanto i for menor ou igual a 10 as instruções serão executadas.
                //Cuidado com o laço ou loop infinito!!


//Imprimir o valor de uma variável i de 1 a 10 e sair do loop quando
//i for maior que 7

var i = 1;
do
{
    Console.WriteLine($"i = {i}");
    i++;

    if (i > 7)
        break;
}
while (i <= 10);

//Instrução do-while aninhadas: Exibir coordenadas do plano(x,y)

int x = 0;
do 
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y}) ");//Primeiro laço do- while
        y++;

    }
    while (y < 5);//Segundo laço do- while
    y++;
    x++;
    Console.WriteLine( );
}
while (x < 5);




Console.WriteLine("\nFim do processamento");
Console.ReadKey( );