

namespace Generics
{
    public interface IPersonaRepository<T> : IRepository<T> where T : Persona, IComparable<T>
    {
        IEnumerable<T> Buscar(string nombre);
    }
}
