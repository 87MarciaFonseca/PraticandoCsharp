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

Console.WriteLine( "Digite um valor para x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite um valor para y");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine( $" valor soma de {x + y}");
Console.WriteLine( $" valor subtração de {x - y}");
Console.WriteLine( $" valor multiplicação de {x * y}");
Console.WriteLine( $" valor divisão de {x / y}");
Console.WriteLine( $" valor exponenciação de {Math.Pow(x ,y)}");
Console.WriteLine( $" valor módulode {x % y}");


Console.ReadKey( );
