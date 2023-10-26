

namespace Generics
{
    public interface IRepository<T> where T : IComparable<T>
    {
        IEnumerable<T> List();
        IEnumerable<T> OrdenarList();
    }
}
