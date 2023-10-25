

namespace Generics
{
    public interface IRepository<T>
    {
        IEnumerable<T> List();
    }
}
