using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Revista : Publicacion
    {
        public string? Periodista { get; set; }

        public Revista(string periodista, string nombre, decimal precio, int cantidadPaginas)
            :base(nombre, precio, cantidadPaginas)
        {
            Periodista = periodista;
        }

        // "override" sobreescribe el metodo padre
        public override string GetDescripcionPublicacion() 
            => $"Revista {Nombre} Periodista : {Periodista} precio {Precio}";

    }
}
