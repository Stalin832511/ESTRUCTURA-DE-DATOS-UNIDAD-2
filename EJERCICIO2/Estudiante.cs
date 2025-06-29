using System;
using System.Collections.Generic;

public class Estudiante
{
    // Lista privada con las asignaturas que estudia el estudiante
    private List<string> asignaturas;

    // Constructor que inicializa las asignaturas
    public Estudiante()
    {
        asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
    }

    // Método que muestra el mensaje "Yo estudio <asignatura>" para cada asignatura
    public void MostrarEstudios()
    {
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
