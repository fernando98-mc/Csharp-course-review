
namespace Generics
{
    public class Estudiante : IComparable<Estudiante>
    {
        public static int EstudianteCount = 0;
        public string? Nombre { set; get; }
        public string? Apellido { set; get; }

        public Estudiante(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            EstudianteCount++;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Apellido}";
        }

        public int CompareTo(Estudiante? miEstudiante)
        {
            //if (obj is null) return 1;
            //if (obj is Estudiante miEstudiente)
            //{
            if (miEstudiante?.Apellido == this.Apellido)
            {
                return this.Nombre!.CompareTo(miEstudiante?.Nombre);
            }
            return this.Apellido!.CompareTo(miEstudiante?.Apellido);
            //}
            //throw new ArgumentException("No es un objeto de tipo estudiante ",nameof(obj));
        }
    }
}
