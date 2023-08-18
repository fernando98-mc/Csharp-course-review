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
        string _nombre;
        string _autor;
        int _cantidadPaginas;

        // constructor          parametros
        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

    }
}
