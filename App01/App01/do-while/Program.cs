

// 1 - El usuarioingresa n veces numeros a sumarse
// 2 - Si el usuario ingres un numero = 0 entonces debe detener el programa
// 3 - Imprime el total de la suma, de los numero ingresados


int acumulador = 0;
int numero = 0;

do
{
    Console.WriteLine("Ingresa los numero a sumar");
    numero = int.Parse(Console.ReadLine()!);
    /* Agrega al acumulador los numeros */
    acumulador += numero;

    /* valida si es 0 es diferente de cero */
} while (numero != 0);

/* Imprime la suma de los numeros */
Console.WriteLine($"El total de la suma es de : {acumulador}");