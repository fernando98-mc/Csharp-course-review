

namespace Generics
{
    public class EstudiantePrinterService
    {
        private readonly IPersonaRepository<Estudiante> _estudianteRepository;

        public EstudiantePrinterService(IPersonaRepository<Estudiante> estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public void PrinterEstudiantes(int max = 100)
        {
            //var estudiantes = _estudianteRepository.List().Take(max);//.ToArray();
            //Array.Sort(estudiantes);
            //Console.WriteLine("Imprimiendo la lista de estudiantes desde printService Estudiantes");
            //for (int i =0; i <estudiantes.Length; i++)
            //{
            //    Console.WriteLine(estudiantes[i]);
            //}

            var estudiantes = _estudianteRepository.OrdenarList().Take(max).ToArray();

            PrinterEstudiantesEnumerable(estudiantes); /* NO ORDENA es mas rapido que el ToArray()*/

            var estudiantesBuscados = _estudianteRepository.Buscar("Ho");
            PrinterEstudianteBusqueda(estudiantesBuscados);
        }

        /*
         * Imprimir desde una coleccion IEnumerable
         * */
        private void PrinterEstudiantesEnumerable(IEnumerable<Estudiante> estudiantes)
        {
            Console.WriteLine("Estudiantes");
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(estudiante);
            }
        }

        private void PrinterEstudianteBusqueda(IEnumerable<Estudiante> estudiantes)
        {
            Console.WriteLine("Estudiantes buscados");
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(estudiante);
            }
        }



    }
}
