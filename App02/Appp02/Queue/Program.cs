

// Crear Queue

Queue<string> numsQueue = new Queue<string>();

// Agregar datos al queue
numsQueue.Enqueue("1");
numsQueue.Enqueue("2");
numsQueue.Enqueue("3");
numsQueue.Enqueue("4");
numsQueue.Enqueue("5");

// Imprimir los datos
foreach (string num in numsQueue)
{
    Console.WriteLine(num);
}


// Buscar al primer elemento
var buscarPrimerNum = numsQueue.Peek();
Console.WriteLine($"El primer numero es : {buscarPrimerNum}");

/**
 * SE ELIMINAN Y SE AGREGAN DESDE LOS PRIMEROS VALORES
 * 
 */

// Eliminar elemento 
string eliminarNum = numsQueue.Dequeue();
Console.WriteLine($"Se eliminara : {eliminarNum}");

foreach (string newNum in numsQueue)
{
    Console.WriteLine(newNum);
}


// Buscar elemento con un datos especificamente
var buscarNum = numsQueue.Contains("3");
Console.WriteLine($"Existe el numero 3 en la lista : {buscarNum}");

if (buscarNum == false)
{
    Console.WriteLine("El numero no existe");
} else
{
    Console.WriteLine("El numero si existe");
}
