

/**
 *  crear delegate
 */
using Delegates;

var objeto = new classFunctions();

MiDelegate f = objeto.funtSuma;

Console.WriteLine($"La suma es : {f(5,9)}");

f = objeto.functMult;
Console.WriteLine($"La multiplicacion es : {f(343,34)}");

var objeto2 = new MiFunction();
f = objeto2.IntanciarDeMetodo;
Console.WriteLine($"El resultado de la operacion es : {f(32234,324)}");

public delegate string MiDelegate(int arg1, int arg2);

