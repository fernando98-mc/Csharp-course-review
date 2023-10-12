

MiDelegate ft1 = (x) => x * x;
Console.WriteLine($"El resultado es : {ft1(6)}");

ft1 = (x) => x * 10;
Console.WriteLine($"El resultado de multiplicar por 10 : {ft1(5)}");

MiDelegateDos ft2 = (x, y) => 
{
    Console.WriteLine($"El resulta de x es : {x}");
    Console.WriteLine($"El resultado de y es : {y}");
};

MiDelegateBool ft3 = (x) => x > 10;
Console.WriteLine($"El resultado debe ser verdadero : {ft3(11)}");
Console.WriteLine($"El resultado debe ser falso : {ft3(5)}");

public delegate int MiDelegate(int x);
public delegate void MiDelegateDos(int x, string y);
public delegate bool MiDelegateBool(int x);