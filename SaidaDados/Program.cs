using System;

Console.WriteLine(   "Saída de Dados:Formatação");
Console.WriteLine( );

int idade = 25;
string nome = "Maria";

Console.WriteLine(nome);
Console.Write(idade);



//Escreve na mesma linha 'Maria tem 25 anos '

Console.Write( nome);
Console.Write(" tem ");
Console.Write( idade);
Console.Write(" anos " );
Console.WriteLine( );
Console.WriteLine(" ------------Concatenação-------------- " );


//usar a concatenação: usando o operador +
Console.WriteLine(nome + " tem " + idade + " anos ");
Console.Write(nome + " tem " + idade + " anos ");//ambos console imprimir da mesma forma
Console.WriteLine();
Console.WriteLine("----------Interpolação------------------");
//usar a interpolação de strings: $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade}  anos ");
Console.WriteLine( "--------------------place holders---------------------");
//uasr place holders: usar {} com numeração com inicio em zero
Console.WriteLine("{0} tem {1}  anos ",nome ,idade);


Console.ReadLine();