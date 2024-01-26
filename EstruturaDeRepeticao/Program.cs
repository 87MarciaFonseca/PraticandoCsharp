
Console.WriteLine("Estrutura de repetição: Instrução goto e label");
//Esse não é mais usado,esse exemplo para apenas fins de contextualização

int i = 1;

repetir:// esse comando identifica uma label

Console.WriteLine($"i = {i}");

i++;

if ( i <= 10 )
    goto repetir;//comando para repetir,esse processo é laço loop

Console.WriteLine( "Fim do processamento..");

Console.ReadKey( );