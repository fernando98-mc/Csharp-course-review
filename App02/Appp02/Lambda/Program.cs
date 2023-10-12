

MiDelegate ft1 = (x) => x * x;
Console.WriteLine($"El resultado es : {ft1(6)}");

ft1 = (x) => x * 10;
Console.WriteLine($"El resultado de multiplicar por 10 : {ft1(5)}");



public delegate int MiDelegate(int x);