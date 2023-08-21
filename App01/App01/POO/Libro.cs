using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Libro : Publicacion
    {   

        private string _autor;
        // PROPIEDAD
        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }

        // constructor          parametros
        public Libro(string nombre, string autor, int cantidadPaginas, decimal precio):base(nombre, precio, cantidadPaginas)
        {
            _autor = autor;
        }

        //public string GetDescripcionLibro()
        //{
        //    return $"{_nombre} por {_autor} cantidad de hojas {_cantidadPaginas}";
        //}

        //  Tecnica con flecha
        public override string GetDescripcionLibro() => $"{Autor} escribio {Nombre} tiene {NumeroPaginas} paginas";


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
