Console.WriteLine("Instrução if e else");
//Exemplo: Comparar se x é maior,menor ou igual a y
/*Console.WriteLine("Informe a nota do aluno");
int nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5)
{
    Console.WriteLine( " Aluno aprovado");
}
else
{
    Console.WriteLine( " Aluno  reprovado");
}
Console.WriteLine( "\n Fim do processamento...");*/

//Exemplo:Comparar se x é maior ,menor ou igual a y,com alinhamento de if e else

Console.WriteLine( "Informe o valor de x\t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Informe o valor de y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    if (x < y)
    {
        Console.WriteLine("x é menor que y");
    }
    else
    {
        Console.WriteLine("x é igual a y");
    }
}

Console.ReadKey();