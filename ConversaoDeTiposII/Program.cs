Console.WriteLine( "## Conversão de tipos ##");

/*int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;// usar o sufixo para decimal e float

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine( s1);
Console.WriteLine( s2);
Console.WriteLine( s3);*/

//conversão de tipos usando a classe Convert
//as conversões de ampliação ou estreitamento entre dois tipos
//de dados que não resultem em perda de dados,terão êxito e o 
//método retornará um valor do tipo de destino

int valorInt = 10;
double valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine( Convert.ToString(valorInt));
Console.WriteLine( Convert.ToDouble(valorDouble));
Console.WriteLine( Convert.ToBoolean(valorBool));
Console.WriteLine( Convert.ToInt32(valorDouble));

//Quando a conersão de estreitamamente de dados resulta em perda
//de dados vai ocorrer uma OverflowException

int varInt = 10000;

Console.WriteLine( Convert.ToByte(varInt));