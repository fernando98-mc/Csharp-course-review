

using Generics;

//var estudiantes = new Estudiante[10];

//estudiantes[0] = new Estudiante("Daya", "Ma");
//estudiantes[1] = new Estudiante("Sandy", "Le");
//estudiantes[2] = new Estudiante("Clary", "Fi");
//estudiantes[3] = new Estudiante("Nancy", "Ro");
//estudiantes[4] = new Estudiante("Moni", "Qu");
//estudiantes[5] = new Estudiante("Jany", "Ma");
//estudiantes[6] = new Estudiante("Lara", "Re");
//estudiantes[7] = new Estudiante("Mars", "Li");
//estudiantes[8] = new Estudiante("Deni", "Ho");
//estudiantes[9] = new Estudiante("Mindi", "Yu");

//Array.Sort(estudiantes);

//for (int i = 0; i < estudiantes.Length; i++)
//{
//    Console.WriteLine(estudiantes[i]);
//}

//var autores = new Autor[10];

//for (int i = 0; i < estudiantes.Length; i++)
//{
//    autores[i] = new Autor(estudiantes[i].Nombre, estudiantes[i].Apellido);
//}

//Console.WriteLine("Esta es la lista de autores");
//Array.Sort(autores);

//for (int i = 0; i < autores.Length; i++)
//{
//    Console.WriteLine(autores[i]);
//}

var estudianteService = new EstudiantePrinterService(new EstudianteRepository());
estudianteService.PrinterEstudiantes(5);

Console.WriteLine($"El total de estudiantes es de : {Estudiante.EstudianteCount}");

//var autoresService = new AutorPrinterRepository(new AutorRepository());
//autoresService.PrinterAutores();

