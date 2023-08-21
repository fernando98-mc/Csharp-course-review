

using POO;


// nombre de clase nombre del objeto instanciar y argumentos "m" -> para decimal
Libro donQuijote = new Libro("Don quijote", "Miguel C.", 1000, 59.90m);
var resultadoLibro = donQuijote.GetDescripcionPublicacion();
Console.WriteLine(resultadoLibro);

Revista times = new Revista("Daya", "Astrnomia", 99.90m, 100);
var resultadoRevista = times.GetDescripcionPublicacion();
Console.WriteLine(resultadoRevista);