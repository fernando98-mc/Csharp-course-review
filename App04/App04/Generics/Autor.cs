﻿
namespace Generics
{
    public class Autor : IComparable
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        public int CompareTo(object? obj)
        {

            if (obj is null) return 1;
            if (obj is Autor miAutor)
            {
                return this.ToString().CompareTo(miAutor.ToString());
            }
            throw new ArgumentException("No es un tipo autor", nameof(obj));
        }
    }
}
