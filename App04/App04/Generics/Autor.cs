
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
            

            
        }
    }
}
