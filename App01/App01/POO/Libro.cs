using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Libro
    {
        // "propiedades"
        private string _nombre;

        // PROPIEDADES
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }


        private string _autor;

        // PROPIEDAD
        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }


        private int _cantidadPaginas;

        // PROPIEDAD MAS USADO
        public int CantidadPaginas { get; set; }

        // constructor          parametros
        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        //public string GetDescripcionLibro()
        //{
        //    return $"{_nombre} por {_autor} cantidad de hojas {_cantidadPaginas}";
        //}

        //  Tecnica con fleca
        public string GetDescripcionLibro() => $"{Autor} escribio {Nombre} tiene {CantidadPaginas} paginas";


        //public string GetNombre()
        //{
        //    return _nombre;
        //}

        //public void SetNombre(string nombreLibro)
        //{
        //    _nombre = nombreLibro;
        //}

        //public string GetAutor()
        //{
        //    return _autor;
        //}

        //public void SetAutor(string autorLibro)
        //{
        //    _autor = autorLibro;
        //}

        //public int GetNumeroPaginas()
        //{
        //    return _cantidadPaginas;
        //}

        //public void SetNumeroPaginas(int numeroPaginas)
        //{
        //    _cantidadPaginas = numeroPaginas;
        //}

    }
}
