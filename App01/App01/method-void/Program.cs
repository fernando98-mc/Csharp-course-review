


//void ImprimirTexto()
//{
//    Console.WriteLine("Hola soy un metodo");
//}

//ImprimirTexto();


// 1 - El usuario ingresa el numero que representa cauntas veces se generara 
//      este valor aleratorio
// 2 - En el bucle se generara un numero aleatorio entre 1 y 1000
// 3 - Imprimir dentro del bucle este numero aleatorio previamente generado


//void ImprimirNumero()
//{
//    Console.WriteLine("Ingreaa un numero alerario");
//    var numeroRandom = int.Parse(Console.ReadLine());
//    var random = new Random();
//    for (int i =1; i <= numeroRandom; i++)
//    {
//        var numeroAleatorio = random.Next(1 , 100);
//        Console.WriteLine($"EL numero random es  : {numeroAleatorio}");
//    }
//}

//ImprimirNumero();


// Metodo con parametros

//void ImprimirNumero(int numeroRandom, string mensaje)
//{   

//    var random = new Random();

//    for (int i = 1; i <= numeroRandom; i++)
//    {
//        var numeroAleatorio = random.Next(1, 100);

//        Console.WriteLine($"{mensaje} : {numeroAleatorio}");
//    }

//}

//ImprimirNumero(5, "Numero es : ");




// Valores por defecto o default

//void ImprimirNumero(int numeroRandom = 3, string mensaje = "hola numero al random") // NO PRIORITARIO
/**void ImprimirNumero(int numeroRandom, string mensaje)
{

    var random = new Random();

    for (int i = 1; i <= numeroRandom; i++)
    {
        var numeroAleatorio = random.Next(1, 100);

        Console.WriteLine($"{mensaje} : {numeroAleatorio}");
    }

}

ImprimirNumero(5, "Numero es : "); // PRIORITARIO si los datos se pasan por metodos


*/



// Cambiar de orden los paramtetros

void ImprimirNumero(int numeroRandom = 3, string mensaje = "Hola desde metodo")
{

    var random = new Random();

    for (int i = 1; i <= numeroRandom; i++)
    {
        var numeroAleatorio = random.Next(1, 100);

        Console.WriteLine($"{mensaje} { i } : {numeroAleatorio}");
    }

}

ImprimirNumero(mensaje: "Cambio de orden de parametros", numeroRandom:4); // SE usa " : " para cambiar de
                                                                          // orderen y se agrega la variable
