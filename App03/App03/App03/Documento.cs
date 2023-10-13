

namespace App03
{
    public class Documento : IOperaciones
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
    }
}
