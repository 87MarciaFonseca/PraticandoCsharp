using System.Diagnostics.CodeAnalysis;

Console.WriteLine( "Inferência Tipos (var) \n");

var idade = 25; // uso do var identificar o tipo da variável
var nome = "Urso";
var salario = 2500m;
Console.WriteLine( $"{nome} tem {idade} e ganha {salario.ToString("c")}");

//var limitações

var salario = null;// não pode atribuir um valor null
var titulo;//declarar não inicializar
var salario, imposto, total//não pode multideclarações 

//não posso mudar o tipo após inicializar

var num = 10;
num =;
num = num + 20;
num = " Teste";

var teste = new Teste();//estanciar é criar um objeto
Console.ReadLine( );

class Teste {

    public void MeuMetodo() {

        Console.WriteLine( "Meu Método");
    }

}
//var é considerado uma forma inferir tipos,identifica sem precisar 
//escrever o tipo,seu user deve ser moderado. 
//usados para declarar tipos anônimos,laços for e foreach
// e  instruções using