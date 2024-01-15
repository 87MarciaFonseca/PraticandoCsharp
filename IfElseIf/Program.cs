

Console.WriteLine("Informe a nota do aluno\t");
var nota = Convert.ToDouble(Console.ReadLine());


if (nota < 5)
{

    Console.WriteLine("\nAluno Reprovado");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("\n Aluno em Recuperação");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("\nAluno Aprovado");

}
else 
{

    Console.WriteLine("\nAluno Aprovado com Distinção");
}

Console.WriteLine("\nFim do Processamento...");

Console.ReadKey();