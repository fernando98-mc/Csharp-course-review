

/**
 *  crear delegate
 
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

*/


// Delegates anonimos

/*
MiDelegate f = delegate (int i, string t) 
{
    return i + 99;
};

var resultado = f(1,"monedas");

Console.WriteLine(resultado);


public delegate int MiDelegate(int a, string txt);


*/

// Delegates compuestos

static void Suma(int a, int b)
{
    string resultadoSuma = (a + b).ToString();
    Console.WriteLine(resultadoSuma);
}

static void Multi(int a, int b)
{
    string resultadoMult = (a * b).ToString();
    Console.WriteLine(resultadoMult);
}

MiDeledate funtS = Suma;
MiDeledate funtM = Multi;

MiDeledate operaciones = funtS + funtM;

int argmt1 = 98;
int argmt2 = 2;

Console.WriteLine("Se esta ejecutando la funcion suma");
Suma(argmt1, argmt2);

Console.WriteLine("Se esta ejecutanto la funcion multiplicacion");
Multi(argmt1, argmt2);

Console.WriteLine("Se esta ejecutando ambas funciones");
operaciones(argmt1, argmt2);

// ejecutar sola la primera
Console.WriteLine("Se esta ejecutando solo la primera funcion -> suma");
operaciones -= Multi;
operaciones(argmt1, argmt2);


public delegate void MiDeledate(int argt1, int argt2);