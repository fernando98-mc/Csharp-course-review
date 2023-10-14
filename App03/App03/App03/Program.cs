﻿

using App03;

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

documento.EnviarMensajeTexto();
documento.EnviarMensaje();
documento.EnviarNotificacion();

IMensaje iMensaje = documento as IMensaje;
iMensaje.EnviarMensajeTexto();