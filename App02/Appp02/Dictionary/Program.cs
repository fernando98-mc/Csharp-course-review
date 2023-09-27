

// Crear un Dictionary
Dictionary<int, string> animalsDictionary = new Dictionary<int, string>();

// Agregar elementos al Dictionary
animalsDictionary.Add(1, "Terrestres");
animalsDictionary.Add(2, "Aves");
animalsDictionary.Add(3, "Acuaticos");
animalsDictionary.Add(4, "Insectos");


// Intentando agregar otro dato
//animalsDictionary.Add(4, "Reptiles"); -> ERROR
var newAnimal = animalsDictionary.TryAdd(4, "Reptiles"); // -> True o False
if (newAnimal == false) // OP if(!newAnimal) -> Cuando no se puede || es negacion
{
    Console.WriteLine($"Es {newAnimal} - No se agrego key duplicado");
} else if (newAnimal == true)
{
    Console.WriteLine($"Es {newAnimal} - Se agrego");
}




// Imprimi el Dicttionary
foreach (KeyValuePair<int, string> animal in animalsDictionary)
{
    Console.WriteLine($"Esta es la lista de animales : {animal.Key} - {animal.Value}");
}


// Acceder al valor del HTML
var animTerrestre = animalsDictionary[1];
Console.WriteLine($"El indice 1 es : {animTerrestre}");

// Actualizar el elemento con el indice
animalsDictionary[3] = "Pecesitos";

// Imprimir nuevos elementos
foreach (KeyValuePair<int, string> printAnimals in animalsDictionary)
{
    Console.WriteLine($"Los datos nuevos son {printAnimals.Key} - {printAnimals.Value}");
}


// Buscar elementos de un diccionariopor key o value -> True o False
Console.WriteLine($"Se encuentra aves : {animalsDictionary.ContainsKey(2)}");
Console.WriteLine($"Se encuentra insectos : {animalsDictionary.ContainsValue("Insectos")}");


// Eliminar elemento con indice
animalsDictionary.Remove(4);

foreach (KeyValuePair<int, string> animalitosActualizada in animalsDictionary)
{
    Console.WriteLine($"Datos actualizados : {animalitosActualizada.Key} - {animalitosActualizada.Value}");
}