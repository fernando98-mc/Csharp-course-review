

using System.ComponentModel;

namespace App03
{
    public class Documento : IOperaciones, IMensaje, INotifyPropertyChanged
    {
        private string nombre;

        public string DocumentoNombre
        {
            get { return nombre; }
            set {
                this.nombre = value;
                NotifyPropchanged("DocumentoNombre");
            }
        }

        //  cosntructor
        public Documento(string s)
        {
            this.nombre = s;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

       public void NotifyPropchanged(string propName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
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
