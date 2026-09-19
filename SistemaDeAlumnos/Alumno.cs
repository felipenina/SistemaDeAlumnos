namespace GestionAlumnos;

public class Alumno : Persona
{
    public double Nota1 { get; private set; }
    public double Nota2 { get; private set; }

    public Alumno(string nombre, int legajo) : base(nombre, legajo)
    {
    }
    public override string Presentarse()
    {
        return $"Hola, soy {Nombre}, alumno con legajo {Documento}.";
    }
    public bool CargarNotas(double nota1, double nota2)
    {
        if (nota1 >= 0 && nota1 <= 10 && nota2 >= 0 && nota2 <= 10)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            return true;
        }

        return false;
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
        return $"{Documento} - {Nombre} (promedio: {Promedio()})";
    }
}