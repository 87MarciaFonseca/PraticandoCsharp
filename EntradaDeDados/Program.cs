using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

Console.WriteLine( " Entrada de dados: Métodos da classe Console");
Console.WriteLine();
Console.WriteLine("-----Ex. da aula do professsor-----");

Console.WriteLine("\n Informe o seu  nome" );
string nome = Console.ReadLine();//Console.ReadLine armazena o valor dessa string
//int idade =Console.Read();// ele só lê um caratéree retorna o seu  valor da tabela ASCII
Console.WriteLine("\n Informe a sua idade");
int idade = Convert.ToInt32( Console.ReadLine() );//converter string para int
Console.WriteLine($"\n O seu nome é  {nome} ");
Console.WriteLine($"\n A sua idade é {idade} anos ");
// para int ,irá retornar uma string
Console.ReadKey(); // esse método só lê um carátere mantém o valor do return static na tela

//Console.WriteLine( "------Ex feito por mim ----");

/*try //try catch é usado para tratamento de erros
{*/
    /*Console.WriteLine( "Insirir o nome do seu banco");
    string banco = Console.ReadLine();
    Console.WriteLine( "Informe seu tipo de conta");
    string tipoconta = Console.ReadLine();
    Console.WriteLine( "Insirir o número da sua conta");
    string numerocontaStr = (Console.ReadLine());
*/
    /*//'new' são usados para inicilizar objetos vindo de uma class
    string numeroconta = formatanumeroconta(numerocontaStr);
    ContaBancaria conta1 = new ContaBancaria(banco, tipoconta, numeroconta);
}

catch (FormatException e)
{
    Console.WriteLine("Erro de formato: Certiique-se de inserir um número válido para 'numeroconta'");
}

catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro não especificado:" + ex.Message);
}
//Uma função não precisa sem estado é estática
static string formatanumeroconta(string numeroconta) 
{
   return numeroconta.Replace(".","").Replace("-", "");
}




//Propriedades são  as caractéristcas do objeto
 public class ContaBancaria // class como se fosse a palnta de uma casa
{
 public string? Banco { get; set; }// public é algo pode ser acessado de fora
 public string? Tipoconta { get;}
 public string? Numeroconta { get; set; }
 public double? Saldo { get; set; }

    //construtor é inicializador das propriedades do objeto descrito em class
    public ContaBancaria(string banco,string tipoonta,
        string numeroconta)
    {

        Banco = banco;
        Tipoconta = tipoonta;
        Numeroconta = numeroconta;
        Saldo = 0.0;

       

    
    }



}

*/