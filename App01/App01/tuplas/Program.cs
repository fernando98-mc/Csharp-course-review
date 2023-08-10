


(int a, string b, bool c) tupla = (15, "Daya", true);
//var tupla = (15, "Daya", true);   // forma IMPLICITA

// setear datos desde la ejecucion
tupla.a = 17;
var tuplaA = tupla.a;

tupla.b = "Dayaa";
var tuplaB = tupla.b;

tupla.c = false;
var tuplaC = tupla.c;

Console.WriteLine($"La edad es de : {tuplaA}");
Console.WriteLine($"El nombre es  : {tuplaB}");
Console.WriteLine($"Es chica : {tuplaC}");