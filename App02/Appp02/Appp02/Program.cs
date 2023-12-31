﻿


// array de personas tipo string
string[] personas = { "Daya", "Mani", "Cele", "Gise", "Gin", "Marianita G." };
//  posicion            0       1       2       3       4      5   


// List Collection - creacion de objeto lista
List<string> listaPersonas = new List<string>();

// agregar data a la lista desde un array
listaPersonas.AddRange(personas);

// agregar un elemento a la lista
listaPersonas.Add("Sera");

// contar cuantas personas hay en la lista
Console.WriteLine($"Hay un total de {listaPersonas.Count} chicas :)");
//Console.WriteLine(listaPersonas[2]);


// ordenar alfabeticamente la lista
listaPersonas.Sort();

// eliminar un elemento de la lista
listaPersonas.RemoveAt(3);     // por indice
listaPersonas.Remove("Mani");  // por valor


// crear un metodo para imprimir todos los elementos de la lista
void ImprimirPersonas(List<string> imprimirPersonas)
{
    foreach (var itemPersona in imprimirPersonas)
    {
        Console.WriteLine($"{itemPersona}");
    }
}

ImprimirPersonas(listaPersonas);

// consultar un elemento de la lista
Console.WriteLine($"El primer elemento de la lista es - {listaPersonas[0]}");



// Este elemento te permite saber si un elemento existe en la lista
Console.WriteLine($"Existe Daya en la lista : {listaPersonas.Contains("Daya")}");


// Este metodo busca quellos nombres con mas de 10 caracteres
var busquedaPersonas = listaPersonas.Exists( x => x.Length > 10);

Console.WriteLine($"Existe un nombre con mas de 10 caracteres = : {busquedaPersonas}");

// Este metodo busca los nombre con "C"
var busquedaPersonaC = listaPersonas.Find(x => x.StartsWith("C"));

Console.WriteLine($"El nombre que empieza con la letra C es : {busquedaPersonaC}");

var busquedaPersonaG = listaPersonas.FindAll( x => x.StartsWith("G"));
Console.WriteLine($"Las personas que empiezan con la letra G son :");
ImprimirPersonas(busquedaPersonaG);