


// Verificar si es mayor de edad


string GetMensajeEdad(int edad)
{

    if (edad > 18)
    {
        return "Es mayor de edad";
    } else
    {
        return "Es menor de edad";
    }

}

var mensaje = GetMensajeEdad(17);

Console.WriteLine($"La persona es : {mensaje}");