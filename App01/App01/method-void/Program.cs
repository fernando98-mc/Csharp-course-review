


//void ImprimirTexto()
//{
//    Console.WriteLine("Hola soy un metodo");
//}

//ImprimirTexto();


// 1 - El usuario ingresa el numero que representa cauntas veces se generara 
//      este valor aleratorio
// 2 - En el bucle se generara un numero aleatorio entre 1 y 1000
// 3 - Imprimir dentro del bucle este numero aleatorio previamente generado


void ImprimirNumero()
{

    Console.WriteLine("Ingreaa un numero alerario");

    var numeroRandom = int.Parse(Console.ReadLine());

    var random = new Random();

    for (int i =1; i <= numeroRandom; i++)
    {
        var numeroAleatorio = random.Next(1 , 100);

        Console.WriteLine($"EL numero random es  : {numeroAleatorio}");
    }

}

ImprimirNumero();