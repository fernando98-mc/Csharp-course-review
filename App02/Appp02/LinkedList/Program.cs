

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
