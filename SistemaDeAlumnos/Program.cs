using GestionAlumnos;


List<Alumno> alumnos = new List<Alumno>();

bool salir = false;

while (!salir)
{
    Console.WriteLine("\n=== MENU DE GESTION DE ALUMNOS ===");
    Console.WriteLine("1. Agregar un alumno");
    Console.WriteLine("2. Listar todos los alumnos");
    Console.WriteLine("3. Buscar un alumno por legajo");
    Console.WriteLine("4. Mostrar el promedio general del curso");
    Console.WriteLine("5. Mostrar cuántos alumnos están aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opción: ");

    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":

            Console.Write("\nIngrese el nombre del alumno: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Ingrese el legajo: ");
            if (!int.TryParse(Console.ReadLine(), out int legajo))
            {
                Console.WriteLine("Legajo inválido. Debe ser un número entero.");
                break;
            }

            Console.Write("Ingrese la nota 1 (0 a 10): ");
            if (!double.TryParse(Console.ReadLine(), out double nota1))
            {
                Console.WriteLine("Nota inválida. Operación cancelada.");
                break;
            }

            Console.Write("Ingrese la nota 2 (0 a 10): ");
            if (!double.TryParse(Console.ReadLine(), out double nota2))
            {
                Console.WriteLine("Nota inválida. Operación cancelada.");
                break;
            }

            
            Alumno nuevoAlumno = new Alumno(nombre, legajo);
            if (nuevoAlumno.CargarNotas(nota1, nota2))
            {
                alumnos.Add(nuevoAlumno);
                Console.WriteLine("¡Alumno agregado con éxito!");
            }
            else
            {
                Console.WriteLine("Error: Las notas deben estar entre 0 y 10. No se agregó el alumno.");
            }
            break;

        case "2":

            Console.WriteLine("\n--- Lista de Alumnos ---");
            if (alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos registrados.");
            }
            else
            {
                foreach (Alumno a in alumnos)
                {
                    Console.WriteLine(a); 
                }
            }
            break;

        case "3":
        
            Console.Write("\nIngrese el legajo a buscar: ");
            if (!int.TryParse(Console.ReadLine(), out int legajoABuscar))
            {
                Console.WriteLine("Legajo inválido.");
                break;
            }

            Alumno? encontrado = alumnos.Find(a => a.Legajo == legajoABuscar);

            if (encontrado != null)
            {
                Console.WriteLine($"Alumno encontrado: {encontrado}");
            }
            else
            {
                Console.WriteLine($"No existe ningún alumno con el legajo {legajoABuscar}.");
            }
            break;

        case "4":
            
            if (alumnos.Count == 0)
            {
                Console.WriteLine("\nNo hay alumnos cargados para calcular el promedio.");
            }
            else
            {
                double sumaPromedios = 0;
                foreach (Alumno a in alumnos)
                {
                    sumaPromedios += a.Promedio();
                }

                double promedioGeneral = sumaPromedios / alumnos.Count;
                Console.WriteLine($"\nEl promedio general del curso es: {promedioGeneral:F2}");
            }
            break;

        case "5":
            int cantidadAprobados = 0;
            foreach (Alumno a in alumnos)
            {
                if (a.EstaAprobado())
                {
                    cantidadAprobados++;
                }
            }
            Console.WriteLine($"\nCantidad de alumnos aprobados: {cantidadAprobados} de {alumnos.Count}");
            break;

        case "6":
            Console.WriteLine("\nSaliendo del programa...");
            salir = true;
            break;

        default:
            
            Console.WriteLine("\nOpción no válida. Por favor, ingrese un número del 1 al 6.");
            break;
    }
}