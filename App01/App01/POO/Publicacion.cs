using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Publicacion
    {
        //          "?" -> no recibe un valor nulo
        public string? Nombre { get; set; }

        public decimal Precio { get; set; }

        public int NumeroPaginas { get; set; }

        public Publicacion(string nombre, decimal precio, int numeroPaginas)
        {
            Nombre = nombre;
            Precio = precio;
            NumeroPaginas = numeroPaginas;
        }

        //     "virtual" hereda a las clases hijos
        public virtual string GetDescripcionPublicacion() => $"{Nombre} cuesta {Precio}";


    }
}
