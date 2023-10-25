
namespace Generics
{
    public class EstudianteRepository : IRepository<Estudiante>
    {
        public Estudiante[] List()
        {
            var estudiantes = new Estudiante[10];

            estudiantes[0] = new Estudiante("Daya", "Ma");
            estudiantes[1] = new Estudiante("Sandy", "Le");
            estudiantes[2] = new Estudiante("Clary", "Fi");
            estudiantes[3] = new Estudiante("Nancy", "Ro");
            estudiantes[4] = new Estudiante("Moni", "Qu");
            estudiantes[5] = new Estudiante("Jany", "Ma");
            estudiantes[6] = new Estudiante("Lara", "Re");
            estudiantes[7] = new Estudiante("Mars", "Li");
            estudiantes[8] = new Estudiante("Deni", "Ho");
            estudiantes[9] = new Estudiante("Mindi", "Yu");
            return estudiantes;
        }
    }
}
