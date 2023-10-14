

namespace App03
{
    public class Documento : IOperaciones, IMensaje
    {
        private string nombre;

        //  cosntructor
        public Documento(string s)
        {
            this.nombre = s;
        }

        public void Cargar()
        {
            Console.WriteLine("Este metodo carga");
        }

        public void Guardar()
        {
            Console.WriteLine("Este metodo guarda");
        }

        public bool NecesitaGuardar()
        {
            return false;
        }


        public void EnviarMensaje()
        {
            Console.WriteLine("Enviar mensaje de po email");
        }

        public void EnviarMensajeTexto()
        {
            Console.WriteLine("Enviar mensaje de texto");
        }

        public void EnviarNotificacion()
        {
            Console.WriteLine("Enviar notificacion push");
        }

    }
}
