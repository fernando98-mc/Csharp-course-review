

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

