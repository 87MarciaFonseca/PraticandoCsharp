Console.WriteLine( "##Conversão de tipos##\n");


//int varInt = 100 ;
//double varDouble = varInt ;


//Console.WriteLine( varDouble); //forma implicita

/*int varInt = 200;

long varLong = varInt;

Console.WriteLine( varLong);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
Decimal numeroDecimal = numeroInt;

Console.WriteLine( numeroInt);
Console.WriteLine( numeroLong);
Console.WriteLine( numeroFloat);
Console.WriteLine( numeroDouble);
Console.WriteLine( numeroDecimal);*/

//tipo explicíto: forca com 'cache' para não ter perdade precisão

double varDouble = 12.456; //8 bytes
int varInt = (int)varDouble;//4 bytes (perda de precisão o cache é o '(int)'

Console.WriteLine( varInt);

int num1 = 10;
int num2 = 4;

float resultado = (float)num1 / num2;
Console.WriteLine( resultado);

Console.ReadLine( );