
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
            if (obj is null) return 1;
            if (obj is Estudiante miEstudiante)
            {
                if (miEstudiante.Apellido == this.Apellido)
                {
                    return this.Apellido!.CompareTo(miEstudiante.Apellido);
                }
                return this.Nombre!.CompareTo(miEstudiante.Nombre);
            }
            throw new ArgumentException("No es un objeto tipo estudiante",nameof(obj));
        }
    }
}
