

// 1 - El usuarioingresa n veces numeros a sumarse
// 2 - Si el usuario ingres un numero = 0 entonces debe detener el programa
// 3 - Imprime el total de la suma, de los numero ingresados


int acumulador = 0;
int numero = 0;

do
{
    Console.WriteLine("Ingresa los numero a sumar");

    try
    {
        numero = int.Parse(Console.ReadLine()!);
    }
    /* catch (Exception e) */ // Forma generica si no sabemos el error
    catch(System.FormatException e)
    {
        /* Imprimimos el error */
        Console.WriteLine($"El tipo de error fue por : {e}");
        /* Salta a la siguiente iteracion */
        continue;
    }

    acumulador += numero;

} while (numero != 0);

Console.WriteLine($"El total de la suma es de : {acumulador}");