
namespace Generics
{
    public class EstudianteRepository : IRepository<Estudiante>
    {
        private NombreCompleto[] _nombres = new NombreCompleto[10];

        public EstudianteRepository()
        {
            _nombres[0] = new ("Daya", "Ma");
            _nombres[1] = new ("Sandy", "Le");
            _nombres[2] = new ("Clary", "Fi");
            _nombres[3] = new ("Nancy", "Ro");
            _nombres[4] = new ("Moni", "Qu");
            _nombres[5] = new ("Jany", "Ma");
            _nombres[6] = new ("Lara", "Re");
            _nombres[7] = new ("Mars", "Li");
            _nombres[8] = new ("Deni", "Ho");
            _nombres[9] = new ("Mindi", "Yu");
        }

        public IEnumerable<Estudiante> List()
        {
            int index = 0;
            while (index < _nombres.Length)
            {
                yield return new Estudiante(_nombres[index].Nombre, _nombres[index].apellido);
                index++;
            }
        }

        public IEnumerable<Estudiante> OrdenarList()
        {
            var estudiantes = List().ToList();
            estudiantes.Sort();
            return estudiantes;
        }
    }
}
