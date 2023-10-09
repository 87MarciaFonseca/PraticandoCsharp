//Exerceicios fase 1:
/*using System.IO.Pipes;
using System.Runtime.InteropServices;

int idade = 35;

Console.WriteLine( idade);

string nome = "Maria";

Console.WriteLine( nome );

double altura = 3.45;

Console.WriteLine( altura);

var data = new DateOnly(1999,04,09);

Console.WriteLine(data );

const int ano = 12;

Console.WriteLine( ano);

double? nota = 7.80;

Console.WriteLine( nota);*/

/*
//Tipo de referência 
Gato gato1 = new Gato (8,"Persa","amarelo","Oriente Médio");
gato1.ExibirGato();
Console.WriteLine( gato1.Raca); //fazer uma seleção de itens do objt

Galinha galinha1 = new Galinha( "Argentina");
galinha1.mostrarGalinha();
struct Galinha//Tipo valor

{
    int Idade = 10;
    string Raca = "Capoeira";
    string Cor = "caramelo";
    string Origem = "Brazil";

    public Galinha(  string origem)
    {
        
        
        Origem = origem;
    }
    public void mostrarGalinha()
    {
        Console.WriteLine( $"{Idade} {Raca} {Cor} {Origem}" );
    }
}

class Gato
{
    public int Idade { get; set; }
    public string? Raca {get; set; } 
   public  string? Cor {  get; set; }

    public string? Origem { get; set; }

    public Gato(int idade, string raca, string cor, string origem)
    {
        Idade = idade; Raca = raca;Cor = cor; Origem = origem;
    }

     public void ExibirGato()
    {
        Console.WriteLine($"{Idade} {Raca} {Cor} {Origem}");
    }


}*/

//Tipos de dados

/*using System.Runtime.Serialization;

int x = 10;
double numero = 7.99;
char letra = 'C';
float temperatura = 27.4f;
bool ativo = false;
string nome = "Manoel";
decimal salario = 950.99m;
DateTime hoje = DateTime.Now;*/

//classificar tipo valor e referência

/*V)int n = 1;
(V)String titulo = "A vida";
(V)float f = 12.45f;
(V)double d = 5.45;
(V)decimal valor = 10.99m;
(V)char sexo = 'M';
(R)object o = null;*/

//O que é um nullable type e qual sua utilidade?

//int ? z = null; // serve para atribuir um valor anulável

//O que é Camel Case ? Dê um exemplo de sua aplicação?

//nomeDaData -utilizada para  nomear variáveis com a primeira
//letra minuscula e segunda e terciera maiuscula

//pascalCase
//ex: 'NomeDaClasse-as primeiras letras inciais são maiuscula


//declarar variáveis x e y ,do tipo int e atribuir valores e imprimir
//a soma:

/*int x = 77;
int y = 66;
int z = x + y;

Console.WriteLine(z);
*/

/*14 - Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
string.

bool = false;
char = null;
int = 0;
double = 0.0;
float = 0.00f;
decimal = o.om;
string = null;

*/
/*15 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis
c*//*onsiderando a nomenclatura usada:*//*
(f ) double 1valor = 12.45;
(f ) string #nome = "Pedro";
(v) float _temperatura = 12.45f;
(f ) double int = 5;
(v ) decimal renda extra = 91.45m;
(f ) bool status$conta = false;
(v ) string titulo3 = “Tópico 1”;
( v) float salario_mensal = 1999.55f;
( v) int percentualValorDesconto = 5;
(v ) const bool MENSALIDADE_EM_DIA = true;*/