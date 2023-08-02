

// Imprimi el texto 80 veces  : Bienvnido al curso

/*
for(int i = 1; i <=80; i++)
{
    Console.WriteLine($"{i} - Bienvenido : ) ");
}
*/


// 1 - El usuario ingresa un numero en la consola
// 2 - El programa se multiplica por los primeros 10 numero ingresados
// 3 - Se debe imprimir el resultado de cada operacion

Console.WriteLine("Ingresa un numero para multiplicar");
var numeroMulyiplicado = int.Parse(Console.ReadLine()!);

Console.WriteLine("------------");

for (int i = 1; i <= 10; i++)
{
    int resultado = numeroMulyiplicado * i;
    Console.WriteLine($"{numeroMulyiplicado} x {i} = {resultado}");
}
