

using App03;
using System.ComponentModel;

var documento = new Documento("Dayaa");
//documento.Guardar();
//documento.Cargar();
//documento.NecesitaGuardar();

if (documento is IOperaciones)
{
    documento.Guardar();
}


IOperaciones Ioperaciobes = documento as IOperaciones;
if (Ioperaciobes is not null)
{
    Ioperaciobes.Cargar();
}

// segundo interface con metodos

documento.EnviarMensajeTexto();
documento.EnviarMensaje();
documento.EnviarNotificacion();

IMensaje iMensaje = documento as IMensaje;
iMensaje.EnviarMensajeTexto();


documento.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($"La propiedad cambio a {e.PropertyName}");
};

documento.DocumentoNombre = "EL book";