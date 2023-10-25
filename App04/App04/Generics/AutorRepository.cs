
namespace Generics
{
    public class AutorRepository : IRepository<Autor>
    {
        public Autor[] List()
        {
            var autores = new Autor[10];

            autores[0] = new Autor("Daya", "Ma");
            autores[1] = new Autor("Sandy", "Le");
            autores[2] = new Autor("Clary", "Fi");
            autores[3] = new Autor("Nancy", "Ro");
            autores[4] = new Autor("Moni", "Qu");
            autores[5] = new Autor("Jany", "Ma");
            autores[6] = new Autor("Lara", "Re");
            autores[7] = new Autor("Mars", "Li");
            autores[8] = new Autor("Deni", "Ho");
            autores[9] = new Autor("Mindi", "Yu");
            return autores;
        }
    }
}
