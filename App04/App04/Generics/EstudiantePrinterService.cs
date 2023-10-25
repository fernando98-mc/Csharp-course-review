﻿

namespace Generics
{
    public class EstudiantePrinterService
    {
        private readonly IRepository<Estudiante> _estudianteRepository;

        public EstudiantePrinterService(IRepository<Estudiante> estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public void PrinterEstudiantes(int max = 100)
        {
            var estudiantes = _estudianteRepository.List().Take(max).ToArray();
            Array.Sort(estudiantes);
            Console.WriteLine("Imprimiendo la lista de estudiantes desde printService Estudiantes");
            for (int i =0; i <estudiantes.Length; i++)
            {
                Console.WriteLine(estudiantes[i]);
            }
        }

    }
}
