

namespace Generics
{
    public interface IRepository<T>
    {
        IEnumerable<T> List();
        IEnumerable<T> OrdenarList();
    }
}
