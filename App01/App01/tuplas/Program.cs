


//(int a, string b, bool c) tupla = (15, "Daya", true);
var tupla = (15, "Daya", true);   // forma IMPLICITA

// setear datos desde la ejecucion
tupla.Item1 = 100;
var tuplaItem1 = tupla.Item1;

tupla.Item2 = "Dayaa";
var tuplaItem2 = tupla.Item2;

tupla.Item3 = false;
var tuplaItem3 = tupla.Item3;

Console.WriteLine($"La edad es de : {tuplaItem1}");
Console.WriteLine($"El nombre es  : {tuplaItem2}");
Console.WriteLine($"Es chica : {tuplaItem3}");