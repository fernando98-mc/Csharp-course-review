

using POO; 
// nombre de clase nombre del objeto instanciar y argumentos
Libro donQuijote = new Libro("Don quijote", "Miguel de cervantes", 100);

donQuijote._nombre = "Don quijote 2";

donQuijote.SetNombre("Don quijote 3");
var nuevoNombre = donQuijote.GetNombre();

var resultado = donQuijote.GetDescripcionLibro();

Console.WriteLine(resultado);