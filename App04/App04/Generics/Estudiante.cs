
namespace Generics
{
    public class Estudiante : IComparable
    {

        public string? Nombre { set; get; }
        public string? Apellido { set; get; }

        public Estudiante(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Apellido}";
        }

        public int CompareTo(object? obj)
        {
            throw 1;
        }
    }
}
