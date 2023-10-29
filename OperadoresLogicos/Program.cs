Console.WriteLine(" Operadores lógicos condicionais");


bool c1 =( 5 >= 7);//false
bool c2 = 9 != 8;//true
bool resultado;


Console.WriteLine( $"c1 = {c1}");
Console.WriteLine( $"c2 = {c2}\n");

//operador AND -> &&
resultado = c1 && c2 || !(c1 && c2);//basta um ser false para resultado ser false
Console.WriteLine("operador AND(&&): " + resultado);
//operador OR -> ||
resultado = c1 || c2; ;//basta um serverdadeiro para o resultado ser verdadeiro
Console.WriteLine($"operador OR(||): " + resultado);
//operador NOT -> !
resultado = !c1 ;//basta inverter o resultado p/ false ou true
Console.WriteLine($"operador NOT(!): " + resultado);

Console.ReadKey();
