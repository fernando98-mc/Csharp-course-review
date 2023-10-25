

namespace Generics
{
    public class EstudiantePrinterService
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EstudiantePrinterService(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public void PrinterEstudiantes()
        {
            var estudiantes = _estudianteRepository.List();
            Array.Sort(estudiantes);
            Console.WriteLine("Imprimiendo la lista de estudiantes desde printService");
            for (int i =0; i <estudiantes.Length; i++)
            {
                Console.WriteLine(estudiantes[i]);
            }
        }

    }
}
