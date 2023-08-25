

string[] ropa= { 
    "Tennis",
    "Sandalias",
    "Playera",
    "Camisa",
    "Blusa",
    "Pantalon",
    "Ropa interior",
    "Short"
};


// Creando LinkedList                        cargar datos "ropa"
LinkedList<string> ropaLinkedList = new LinkedList<string>(ropa);

// Agregamos elementos a la lista inicio
ropaLinkedList.AddFirst("Corbata");

// Agregamos elementos a la lista final
ropaLinkedList.AddLast("Pants");

foreach (string listaRopa in ropaLinkedList)
{
    Console.WriteLine(listaRopa);
}




// Buscar primera ropa
LinkedListNode<string> primerRopa = ropaLinkedList.First!;
// Buscar la ultima ropa
LinkedListNode<string> ultimaRopa = ropaLinkedList.Last!;


//                              "value" imprime el valor string 
Console.WriteLine($"La primera ropa es : {primerRopa.Value}");
Console.WriteLine($"La ultima ropa es : {ultimaRopa.Value}");

// Los elemento pueden ser removidos o eliminados de un item existente
ropaLinkedList.AddAfter(primerRopa, "Traje");
// eliminar
//ropaLinkedList.RemoveFirst(primerRopa, "traje");

foreach (string listaRopa in ropaLinkedList)
{
    Console.WriteLine(listaRopa);
}

Console.WriteLine($"Se agrego traje en la lista ");


// Buscar elemento
Console.WriteLine($"Buscar elemento Blusa : {ropaLinkedList.Contains("Blusa")}");


// Acceder a la data utilizando los metodos siguiente Next y Previus(siguiente y anterior)
Console.WriteLine($"La ropa siguiente a la primera es : {primerRopa.Next!.Value}");
Console.WriteLine($"La ropa anterior a la ultima es : {ultimaRopa.Previous!.Value}");