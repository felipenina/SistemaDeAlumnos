using GestionAlumnos;

List<Persona> personas = new List<Persona>();

personas.Add(new Alumno("Ana Pérez", 1234));
personas.Add(new Profesor("Marta Díaz", 23456789, "Programación"));
personas.Add(new Preceptor("Carlos Ruiz", 30123456, "Mañana"));

foreach (Persona p in personas)
{
    Console.WriteLine(p.Presentarse());
}