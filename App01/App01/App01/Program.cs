﻿//// Comentario de una sola linea

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
 * 3 - El programa captura estos valores y los almacena en variables
 * 4 - El programa se encarga de realizar la operacion matematica
 * 5 - El programa se encarga imprimir el resultado de la operacion
 * 
 */

Console.WriteLine("Escribe el primer numero");
var primerNumeroString = Console.ReadLine();
var primerNumeroInt = int.Parse(primerNumeroString!); // con "!" le decimos que nosera null

Console.WriteLine("Escribe el segundo nimero");
var segundoNumeroString = Console.ReadLine();
var segundoNumeroInt = int.Parse(segundoNumeroString!); // con "!" le decimos que nosera null

var resultadoSuma = primerNumeroInt + segundoNumeroInt;
var resultadoResta = primerNumeroInt - segundoNumeroInt;
var resultadoMultiplicacion = primerNumeroInt * segundoNumeroInt;
var resultadoDivision = primerNumeroInt / segundoNumeroInt;


Console.WriteLine("El resultado de la SUMA es : " + resultadoSuma);
Console.WriteLine("El resultado de la RESTA es : " + resultadoResta);
// concatener usando $ y {}
Console.WriteLine($"El rsultado de la MULTIPLICACION es : {resultadoMultiplicacion}");
Console.WriteLine($"El resultado de la DIVISION es : {resultadoDivision}");
