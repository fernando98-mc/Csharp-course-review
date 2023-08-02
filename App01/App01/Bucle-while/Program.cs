

// 1 - El usuario ingresa un numero
// 2 - El programa captura el numero e imprimi una lista de numeros
//      mayores hasta el maximo de 100
// REGLA : El numero ingresado por el usuario no debe ser mayoro igual a 100


Console.WriteLine("Ingresa un numero menor igual a 100");

int numero = int.Parse(Console.ReadLine()!);

while (numero <= 100)
{
    Console.WriteLine(numero);
    numero++;
}