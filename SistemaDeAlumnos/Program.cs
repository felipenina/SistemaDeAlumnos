using GestionAlumnos;
Alumno alumno = new Alumno("Ana Pérez", 1234);

bool seCargaronMal = alumno.CargarNotas(47, 8);
if (!seCargaronMal)
{
    Console.WriteLine("Error: Las notas ingresadas son inválidas (deben estar entre 0 y 10).");
}

bool seCargaronBien = alumno.CargarNotas(7, 8);
if (seCargaronBien)
{
    Console.WriteLine("Notas cargadas correctamente.");
}


Console.WriteLine(alumno);