using Eventos;


var obj = new EventPublisher();

obj.valueChanged += new MiEventoHandler(obj_valueChanged);

void obj_valueChanged(String value)
{
    Console.WriteLine($"El valor de la propiedad cambio {value}");
}

string palabra;

do
{
    Console.WriteLine("Ingresa un valor");
    palabra = Console.ReadLine()!;

    if (!palabra.Equals("exit"))
    {
        obj.Val = palabra;
    }

} while (!palabra.Equals("exit"));

Console.WriteLine("El programa se cerro por el exit");

public delegate void MiEventoHandler(String value);