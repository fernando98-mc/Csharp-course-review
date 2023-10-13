using Eventos_con_Lambda;


var miClaseLambda = new MiClaseLambda();
miClaseLambda.valueChange += (x) =>
{
    Console.WriteLine($"El valor de la propiedad cambio {x}");
};

string palabra;

do
{
    palabra = Console.ReadLine();
    if (!palabra.Equals("exit"))
    {
        miClaseLambda.val = palabra;
    }
} while (!palabra.Equals("exit"));

Console.Write("Programa ha finalizado");

public delegate void MiEventoHandler(string value);