namespace GestionAlumnos;

public class Alumno
{
   
    public string Nombre { get; set; }
    public int Legajo { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public Alumno(string nombre, int legajo, double nota1, double nota2)
    {
        Nombre = nombre;
        Legajo = legajo;
        Nota1 = nota1;
        Nota2 = nota2;
    }
   
    public double Promedio()
    {
        return (Nota1 + Nota2) / 2.0;
    }

    
    public bool EstaAprobado()
    {
        return Promedio() >= 6.0;
    }

    public void SubirNota()
    {
        Nota1 = Math.Min(10.0, Nota1 + 1.0);
        Nota2 = Math.Min(10.0, Nota2 + 1.0);
    }
    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (promedio: {Promedio()})";
    }
}