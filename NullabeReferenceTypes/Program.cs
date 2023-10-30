Console.WriteLine( " Tipos de referência Anuláveis \n");

string? nome1 = null;//sem operador ? ,emitido uma alerta do compilador
string? nome2 = "";

Console.WriteLine( nome1?.ToUpper());//utilizar operador null'?' e ToUpper p/eveitar o erro

Console.WriteLine(nome1?.ToUpper());//ambas expressões vão dá o mesmo resultado
//null,devido atulização dos operadores.

Console.ReadKey( );


