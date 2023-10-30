using System.Threading.Channels;

Console.WriteLine( " Operador Uniário e Ternário \n");
/*
//operador uniário:
int positivo = 1;
int resultado1;

resultado1 = +positivo;//deve ser um tipo aritmético,mas operador + não tem
                      //efeito na expressão
Console.WriteLine( resultado1);

//operador uniário
Console.WriteLine( "Informe o numero:\n");//dever ser um aritmético
var n = Convert.ToInt32(Console.ReadLine() );//produz o negatigo do seu operando

Console.WriteLine( $" O negativo de {n} é igual a {-n}");

//operador condicional ternário (?:) expressão booleana

Console.WriteLine( " Informe a temperatura: \n");
var temp = Convert.ToDouble(Console.ReadLine()); //receber via teclado o valor e
//converter o valor para ToDouble

var resultado2 = temp > 27 ? " Quante" : "Normal";//operador condicional ternário
  //avaliar uma das duas expressões booleanas
//retornar como true ou false

Console.WriteLine( $" O tempo esta  {resultado2}");*/

//operador condicional ternário(?:) - alinhando operações
Console.WriteLine( " Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

string resultado = x > y ? " x é maior que y":
                   x < y ? " x é menor que y":
                   x == y ? " x é igual a y " : " Sem resultado";
Console.WriteLine( resultado);

Console.ReadKey( );