

namespace Generics
{
    public interface IPersonaRepository<T> : IRepository<T> where T : Persona, IComparable<T>, new()
    {
        IEnumerable<T> Buscar(string nombre);

        T Crear(NombreCompleto nombre);

        T CrearPorDefecto();
    }


    /**
     *  ALTERNATIVA AL USO DE CONSTRAINS
     */

    //public interface IPersonaReporsitory
    //{
    //    //                              constrin a nivel de codigo
    //    IEnumerable<T> Buscar<T>(string nombre) where T :Persona;

    //    T Crear<T>(NombreCompleto nombre) where T : Persona;

    //    T CrearPorDefect<T>() where T : Persona;

    //}

}
