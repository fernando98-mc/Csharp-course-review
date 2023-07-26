//// Comentario de una sola linea

///**
// * Este es el comentatio multilineas
// * de curso de C#
// */

//string nombre = "Dayu";
//var pagina = "http://WWW.mipagina.com";

//int miNumeroEntero = 100;
//int otroNumeroEntero = -50;

//float miFloatNumero = 34.65f;

//double miDoubleNumero = 132.21;

//// transacciones money
//decimal miDecimal = 123.32423m;

////max 250 en byte
//byte miNumeroByte = 249;

//bool miBooleano = true;

//string miCadena = "es una cadena de texto";
//miCadena = "esta es mi nueva cadena";

//// solo alamacena un caracter
//char micaracter = 'A';

//// las constante no se pueden alterar
//const int misNumero = 213;

//// paea usar null se necesita poner "?" despues del tipo de dato

//bool? miBoleanoNull = null;

//int? miNumeroNull = null;

//// string en versiones nuevas no requiere "?"
//string miCadenaNull = null;


//Console.WriteLine("Hello, soy " + nombre + " y mi pagina es " + pagina);

// ESTRUCTURAS DE CONTROL LOGICO 


/**
 * Este algoritmo se encargara de ralizar las operaciones basicas de dos numeros
 * 
 * 1 - El cliente ingresa un numero X
 * 2 - El cliente ingresa el segundo numero  y
 * 3 - El usuario ingresa el tipo de opereacion a realizar suma, resta, multiplicacion o divicion
 * 4 - El programa captura estos valores y los almacena en variables
 * 5 - El programa se encarga de realizar la operacion matematica
 * 6 - El programa se encarga imprimir el resultado de la operacion
 * 
 */

Console.WriteLine("Escribe el primer numero");
var primerNumeroString = Console.ReadLine();

//if(primerNumeroString is null || primerNumeroString == "")
//{
//    Console.WriteLine("El programa finalizao por un error");
//    return;
//}


if(string.IsNullOrEmpty(primerNumeroString))
{
    Console.WriteLine("El numoer ingresa es nulo o esta vacio, segun isNullOrEMpty");
    return;
}


// ALGORITMO PARA EVALUAR SI UN TEXTO TIENE LA NOMENCLATURA DE NUMERO
// SI ES POSIBLE CONVERTIR UN TEXTO A NUMERO
// 1 - Es declarar una variable resultado posible
// 2 - Condicionar si el texto esta realmente escrito en una nomenclatura numerica
// 3 - En caso de que no sea un numero, entonces termian el programa
// 4 - En caso de que si sea un numero entonces continua la ejecucion del programa


int primerNumeroInt = 0;

// si no es un numero
if(! int.TryParse(primerNumeroString, out primerNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}

if(primerNumeroInt >= 100)
{
    Console.WriteLine("Su numero es mayor o igual a 100");
}
else 
{
    Console.WriteLine("Su numero es menor que 100");
}


if(primerNumeroInt <= 10)
{
    Console.WriteLine("El numero es menor o igual que 10");
} else if (primerNumeroInt >10 && primerNumeroInt <=20)
{
    Console.WriteLine("El numero es mayor que 10 p menor igual a 20");
} else
{
    Console.WriteLine("El numero es mayor que 20");
}

//var primerNumeroInt = int.Parse(primerNumeroString!); // con "!" le decimos que nosera null

Console.WriteLine("Escribe el segundo numero");
var segundoNumeroString = Console.ReadLine();

if(string.IsNullOrEmpty(primerNumeroString))
{
    Console.WriteLine("El segundo numoer esta en blanco o es nulo");
    return;
}

int segundoNumeroInt = 0;

// "!" negacion para saber sino lo puede convertir
if( !int.TryParse(segundoNumeroString, out segundoNumeroInt))
{
    Console.WriteLine("El valor ingresado no es un numero");
    return;
}

Console.WriteLine("Selecccionar 1 - Sume " +
                               "2 - Resta" +
                               "3 - Multiplicacion" +
                               "4 - Divicion");

int tipoOperacion = int.TryParse(Console.ReadLine(), out tipoOperacion) ? tipoOperacion : 0;

//var segundoNumeroInt = int.Parse(segundoNumeroString!); // con "!" le decimos que nosera null






//var resultadoSuma = primerNumeroInt + segundoNumeroInt;
//var resultadoResta = primerNumeroInt - segundoNumeroInt;
//var resultadoMultiplicacion = primerNumeroInt * segundoNumeroInt;
//var resultadoDivision = primerNumeroInt / segundoNumeroInt;

// OPERADORES DE ASIGNACION
//var resultadoSuma = primerNumeroInt;
//resultadoSuma += segundoNumeroInt;

//var resultadoResta = primerNumeroInt;
//resultadoResta -= segundoNumeroInt;

//var resultadoMultiplicacion = primerNumeroInt;
//resultadoMultiplicacion *= segundoNumeroInt;

//var resultadoDivision = primerNumeroInt;
//resultadoDivision /= segundoNumeroInt;


//Console.WriteLine("El resultado de la SUMA es : " + resultadoSuma);
//Console.WriteLine("El resultado de la RESTA es : " + resultadoResta);
//// concatener usando $ y {}
//Console.WriteLine($"El rsultado de la MULTIPLICACION es : {resultadoMultiplicacion}");
//Console.WriteLine($"El resultado de la DIVISION es : {resultadoDivision}");
