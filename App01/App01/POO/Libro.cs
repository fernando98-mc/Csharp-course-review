using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Libro
    {
        // propiedades
        public string _nombre;
        protected string _autor;
        private int _cantidadPaginas;

        // constructor          parametros
        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        public string GetDescripcionLibro()
        {
            return $"{_nombre} por {_autor} cantidad de hojas {_cantidadPaginas}";
        }

    }
}
