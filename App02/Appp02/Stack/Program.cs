

// crear un stack collection
Stack<string> stackNumeros = new Stack<string>();

// Agregar datos al stack
stackNumeros.Push("uno");
stackNumeros.Push("dos");
stackNumeros.Push("tres");    
stackNumeros.Push("cuatro");
stackNumeros.Push("cinco");

// imprimir numeros del stack
foreach (string impNumeros in stackNumeros)
{
    Console.WriteLine(impNumeros);
}

// Buscar al primer elemento
string primerNum = stackNumeros.Peek();
Console.WriteLine($"El primer numero es : {primerNum}");


// Remover eliminar elemento
string eliminarNum = stackNumeros.Pop();
Console.WriteLine($"Se ha eliminado el siguiente numero : {eliminarNum}");

foreach ( string impNums in stackNumeros)
{
    Console.WriteLine(impNums);
}


// Buscar elemento con "Contains"
var buscarNum = stackNumeros.Contains("uno");
Console.WriteLine($"¿El numero uno si existe? : {buscarNum}");

