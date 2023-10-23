Console.WriteLine("Operadores de incremento e decremento \n") ;

/*int x = 10;
x++; //incremento para decremento só substituir por '--'
Console.WriteLine( x);
*/
//formas de uso
//pré-incremento:++x
//pós-incremento: x++
//operador de decremento: --
//pré-decremento: --x
//pós-decremento: x--
/*
int x = 0;
Console.WriteLine( $"x = {x}");
//pós-incremento ->primeiro resolve depois incrementa
int resultado1 = x++ + 10;

Console.WriteLine( $"pós-incremento ==>{resultado1}");
Console.WriteLine( $"Valor de x ==> {x}\n");

//pré-incremento ->primeiro incrementa depois resolve
int y = 0;
int resultado2 = ++y + 10;

Console.WriteLine($"pré-incremento ==>{resultado2}");
Console.WriteLine($"Valor de x ==> {y}\n")*/;

int x = 0;
Console.WriteLine($"x = {x}");
//pós-decremento ->primeiro resolve depois decrementa
int resultado1 = x-- + 10;

Console.WriteLine($"pós-decremento ==>{resultado1}");
Console.WriteLine($"Valor de x ==> {x}\n");

//pré-decremento ->primeiro decrementa depois resolve
int y = 0;
int resultado2 = --y + 10;

Console.WriteLine($"pré-decremento ==>{resultado2}");
Console.WriteLine($"Valor de x ==> {y}\n");



Console.ReadLine( );