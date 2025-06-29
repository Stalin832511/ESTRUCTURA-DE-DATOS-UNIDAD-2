using System;
using System.Collections.Generic;

public class RegistroNotas
{
    // Diccionario que almacena asignatura y nota asociada
    private Dictionary<string, double> notas;

    // Constructor que inicializa el diccionario vacío
    public RegistroNotas()
    {
        notas = new Dictionary<string, double>();
    }

    // Método que solicita al usuario ingresar la nota para cada asignatura
    public void IngresarNotas()
    {
        // Lista de asignaturas fijas
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        // Iterar para pedir nota de cada asignatura
        foreach (var asignatura in asignaturas)
        {
            Console.Write($"Ingrese la nota de {asignatura}: ");
            double nota = Convert.ToDouble(Console.ReadLine());
            // Guardar nota en el diccionario
            notas[asignatura] = nota;
        }
    }

    // Método que muestra las notas ingresadas por asignatura
    public void MostrarNotas()
    {
        foreach (var item in notas)
        {
            Console.WriteLine($"En {item.Key} has sacado {item.Value}");
        }
    }
}
