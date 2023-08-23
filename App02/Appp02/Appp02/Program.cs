


// array de personas tipo string
string[] personas = { "Daya", "Mani", "Cele" };
//  posicion            0       1       2


// List Collection - creacion de objeto lista
List<string> listaPersonas = new List<string>();

// agregar data a la lista desde un array
listaPersonas.AddRange(personas);

// agregar un elemento a la lista
listaPersonas.Add("Sera");

// contar cuantas personas hay en la lista
Console.WriteLine($"Hay un total de {listaPersonas.Count} chicas :)");
Console.WriteLine(listaPersonas[2]);