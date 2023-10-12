using Eventos;


var obj = new EventPublisher();

obj.valueChanged += delegate (String val)
{
    Console.WriteLine($"El valor de la propiedad cambio a : {val}");
};

obj.valueChanged += new MiEventoHandler(obj_valueChanged1);
void obj_valueChanged1(string value)
{
    Console.WriteLine($"Se esta iniciando el evento handlre 2 {value}");
}

obj.valueChanged += new MiEventoHandler(obj_valueChanged2);
void obj_valueChanged2(String value)
{
    Console.WriteLine($"Se est iniciando el evento handler 3 {value}");
}

obj.miEvento += delegate (object sender, MiEventoArgs e) 
{

    Console.WriteLine($"{sender.GetType()} la propiedad que cambio como  {e.data}");

};

//obj.valueChanged += new MiEventoHandler(obj_valueChanged);

//void obj_valueChanged(String value)
//{
    //Console.WriteLine($"El valor de la propiedad cambio {value}");
//}

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