

namespace Generics
{
    public class EstudiantePrinterService
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EstudiantePrinterService(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }



    }
}
