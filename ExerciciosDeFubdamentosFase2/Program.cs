Console.WriteLine( " Exercícios fase2 \n");


/*//exercício 01:

string nome = "Paulo";
int idade = 17;
double nota = 7.5;



Console.WriteLine($" Aluno {nome} tem {idade} anos e {nota} *//*");*/



/*//exercício 02

string nome = "Paulo";
int idade = 17;
double nota = 7.5;

string mensagem ="Nome: "+ nome +"\nIdade:" +idade +"\nNota: " + nota;

Console.WriteLine( mensagem);

//Exercício 03: converter um float implicitamente
float floatValue = 3.14f;
int intValue = (int)floatValue;// conversão explícita
Console.WriteLine( intValue);//saída 3

(x)int//4 bytes
()double//8 bytes
()long//8 bytes
(x)decimal//16bytes

//Exercício04
() int para long
(x)double para long
(x)double para float
(x)decimal para float
(x)long para int
(x)double para decimal*/

//Exercício 05

/*Console.WriteLine( "Informe uma letra");
char letra1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Digite a segunda letra");
char letra2 = Convert.ToChar(Console.ReadLine());
Console.WriteLine( "Digite a terceira letra");
char letra3 = Convert.ToChar(Console.ReadLine()) ;
string concatenacao =  letra1+ " " + letra2 + " " + letra3;
Console.WriteLine( concatenacao );
Console.WriteLine( $"{letra3} {letra2} {letra1}");*/

//Exercício 06:marque(v) ou (f) p/ os códigos abaixo:
/*(f) long resultado = 1.32;
(v) var nome = " Maria";
(v) string resultado = 100.ToString();
(v) A sequência de escape \n inclui uma nova linha;
(f) float f = 5.45;
(v) decimal valor = (decimal)10.99f;
(f) var status = null;
(v) object 0 = 12.45m;
(v) string titulo = true.ToString();
(f) A sequencia\t inclui uma tabulação vertical*/

//Exercício 07

/*Console.WriteLine( "Digite um valor para x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite um valor para y");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine( $" valor soma de {x + y}");
Console.WriteLine( $" valor subtração de {x - y}");
Console.WriteLine( $" valor multiplicação de {x * y}");
Console.WriteLine( $" valor divisão de {x / y}");
Console.WriteLine( $" valor exponenciação de {Math.Pow(x ,y)}");
Console.WriteLine( $" valor módulode {x % y}");

*/


//*/Exercício08 

/*int a = 1, b = 12, c = -13;
double delta, x1, x2;

delta = Math.Pow(b,2) - 4 * a * c ;

 x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
 x2 = ((-b) - Math.Sqrt(delta)) / 2 * a;
Console.WriteLine( "x1 = " + x1);
Console.WriteLine( "x2 = " + x2);*/

//Exercício 09
Console.WriteLine( "\n Informe seu nome \t");
string nome = Console.ReadLine();
Console.WriteLine( "\n Informe a  sua senha \t");
int senha = Convert.ToInt32(Console.ReadLine());

var resultado = (nome == "admin"|| nome == " Maria ") && senha == 123? "login  legal": "falhou";

Console.WriteLine( resultado);

//Exercicio 10

( v) string? nome; é um exemplo de nullable reference type;
(v ) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
( f) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
(v ) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
(v ) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
(v ) Para x = 25 e y=5 , a expressão ( y >= x ) && (y <= x); retorna true;
( ) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
( ) Para x = 10, o código Console.WriteLine(x+=x); imprime o valor 10;
( ) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
( ) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
( ) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?( ) string? nome; é um exemplo de nullable reference type;
( ) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
( ) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
( ) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
( ) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
( ) Para x = 25 e y=5 , a expressão ( y >= x ) && (y <= x); retorna true;
( ) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
( ) Para x = 10, o código Console.WriteLine(x+=x); imprime o valor 10;
( ) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
( ) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
( ) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?


Console.ReadKey( );

