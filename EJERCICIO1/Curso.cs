using System;
using System.Collections.Generic;

public class Curso
{
    // Lista privada que almacena las asignaturas del curso
    private List<string> asignaturas;

    // Constructor que inicializa la lista con asignaturas predeterminadas
    public Curso()
    {
        asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
    }

    // Método para obtener la lista de asignaturas (si se necesita acceder desde fuera)
    public List<string> ObtenerAsignaturas()
    {
        return asignaturas;
    }

    // Método que muestra todas las asignaturas por consola
    public void MostrarAsignaturas()
    {
        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}
