

// Objetivo : Calcular el sueldo total de un empleado
// 1 - El metodo recibe los valores de salario, impuesto  y salud
// 2 - calcula el total que debe recibir de salario en funcion a estos parametros
// 3 - El metodo debe devolver el salario total



// PARAMETROS POR REFERENCIA


                                                        // parametro por referecia,  salida " out "
void CalcularSalario(int salario, int impuesto, int salud, out int total)
{
    total = salario - impuesto - salud;
}

var salarioTotal = 0;
                                        //  recipiente de "total"
CalcularSalario(salario:300, impuesto:50, salud:50, out salarioTotal);

Console.WriteLine($"El salario total fue de : {salarioTotal}");