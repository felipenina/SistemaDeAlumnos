using GestionAlumnos;

List<Materia> materias = new List<Materia>()
{
    new Materia("PROG1", "Programación I", 128),
    new Materia("BD1", "Bases de Datos I", 96)
};

List<IExportable> exportables = new List<IExportable>();

Alumno a1 = new Alumno("Ana Pérez", 1234);
a1.CargarNotas(7, 7);

Profesor p1 = new Profesor("Marta Díaz", 23456789, "Programación");

exportables.Add(a1);
exportables.Add(p1);
exportables.Add(materias[0]); 

foreach (IExportable item in exportables)
{
    Console.WriteLine(item.ExportarLinea());
}