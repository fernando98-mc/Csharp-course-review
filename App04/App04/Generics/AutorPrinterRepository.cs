

namespace Generics
{
    public class AutorPrinterRepository
    {

        private readonly IRepository<Autor> _repositoryAutor;

        public AutorPrinterRepository(IRepository<Autor> repositoryAutor)
        {
            _repositoryAutor = repositoryAutor;
        }

        public void PrinterAutores()
        {
            var autores = _repositoryAutor.List();
            Array.Sort(autores);
            Console.WriteLine("Imprimiendo autores desde PrinterAutores");
            for (int i = 0; i<autores.Length; i++)
            {
                Console.WriteLine(autores[i]);
            }
        }

    }
}
