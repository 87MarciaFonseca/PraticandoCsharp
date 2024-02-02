Console.WriteLine("Instrução For");

//Loop for - estrutura :
//for (inicialização;condição;iteração)
//{
//instruções
//
//}

//Loop For: Aplicação usando número inteiro
for (int i = 0, j = 0; i + j <= 20; i++, j++)
{
    Console.WriteLine($"i ={i} e j={j}");

}


for (int x = 0; x < 5; x++)
{

    for (int y = 0; y < 5; y++)
    {

        Console.Write($"({x},{y})  ");
    }
    Console.WriteLine();
}


//Programa c# usando laço for para exibir a tabuada de multiplicação 
//de número  doubles,que podem ser usados int também.

double resultado, numero;
double i;

Console.Write(" Informe o número inteiro maior que zero:\t");
numero = Convert.ToInt32(Console.ReadLine());



for (i = 1.01; i <= 10.10; i += 0.1) //for (var i = 1; i<= 10; i++) p/ inteiros
{
    resultado = numero * i;
    //Console.WhriteLine(numero + "x" + i + "=" + resultado)
    Console.WriteLine(numero + "x" + i + " = " + resultado);
}





// O mesmo código,agora usando if para válida um numero.

double resultado, numero;
double i;

Console.Write(" Informe o número inteiro maior que zero:\t");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)// para valid~ção de número

{

    for (i = 1; i <=  20; i+=2) //for (var i = 1; i<= 10; i++) p/ inteiros
    {
        resultado = numero * i;
        //Console.WhriteLine(numero + "x" + i + "=" + resultado)
        Console.WriteLine(numero + "x" + i + " = " + resultado);
    }



}
else
{

    Console.WriteLine(" Número inválido");
}


Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
