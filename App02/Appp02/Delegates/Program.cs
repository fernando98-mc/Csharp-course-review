

/**
 *  crear delegate
 */
using Delegates;

var objeto = new classFunctions();

MiDelegate f = objeto.funtSuma;

Console.WriteLine($"La suma es : {f(5,9)}");



public delegate string MiDelegate(int arg1, int arg2);

