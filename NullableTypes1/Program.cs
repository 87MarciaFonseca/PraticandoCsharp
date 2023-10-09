Console.WriteLine( "##Nullable Types##\n");

//int valor = null;

//Console.WriteLine( valor );
//adicionando valores Nullable Tye:Nullable<T><nome>=null; (T= int,double,bool,etc..)
//Nullable<int> i = null;
//Nullable<double> d = null;
//Nullable<bool> b = null;

//Console.WriteLine(i );
//Console.WriteLine(d );
//Console.WriteLine( b);

//NUllable Types: declaração simplicada usando "?"

//int? i = null;
//double? d = null;
//bool? b = null;
//float? f = null;

//Console.WriteLine( i);
//Console.WriteLine( d);
//Console.WriteLine( b);
//Console.WriteLine( f);

//Atribuir um Nullable Type a um tipo por valor usando operador '??'
//ex:Use o perador '??' para atribuir um tipo anulável a um tipo não anulável
//int? a = null;
//int b = a ?? 0;
//Console.WriteLine( b);

//int? a = 1;

//int c = a ?? 0;

//Console.WriteLine( c);

//int? x  = 4;
//int? y = 3;
//int? z = x * y;

//Console.WriteLine(z);

//Popriedade somente leitura:HasVlue e Vulue
//HasValue: true se tiver um valor false se não tiver um valor (null);
//Value: exibe o valor atribuido;

int? b = null;
if (b.HasValue)

{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine( "b não possui valor (null)");

}




Console.ReadKey( );