Console.WriteLine( "Precedência e associatividade de operadores");
//ordem descrescente de precedência:
//{},(),++,--(sufixo): da esquerda para a direita
//!,++,--(prefixo):da direita para a esquerda
//*,/.%:da esquerda para a direita
//+,-:da esquerda para a direita
//<,>,<=,>=:da esquerda para a direita
//==,!=:da esquerda para a direita
//&&:da esquerda para a direita
//||:da esquerda para a direita
//=,*=,/=,%=,+=,-=:da direita para a esquerda

//operadores aritméticos ->ordem de precedência: +,/,* ,- ou {},()

/*i*//*nt *//*x = (10 - 2) * 3;

Console.WriteLine( x );

//operadores lógicos->ordem de precedência: !,&&,|| ,{}()

bool b = !(9 != 8) && (5 >= 7 || 8 >= 6);

Console.WriteLine(b);*/

//ordem de precedência:exemplo
int a = 5, b = 6, c = 4;
int r = --a* b - ++c;
Console.WriteLine( r );

Console.ReadKey();
