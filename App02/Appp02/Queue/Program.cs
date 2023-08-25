

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