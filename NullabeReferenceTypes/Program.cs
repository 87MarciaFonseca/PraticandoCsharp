Console.WriteLine( " Tipos de referência Anuláveis \n");

string? nome = null;//sem operador ? ,emitido uma alerta do compilador

Console.WriteLine( nome?.ToUpper());//utilizar operador null'?'p/eveitar o erro


Console.ReadKey( );


