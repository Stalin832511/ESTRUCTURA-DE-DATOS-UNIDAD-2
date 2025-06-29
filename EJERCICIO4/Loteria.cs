using System;
using System.Collections.Generic;

public class Loteria
{
    // Lista que almacena los números ganadores ingresados
    private List<int> numerosGanadores;

    // Constructor que inicializa la lista vacía
    public Loteria()
    {
        numerosGanadores = new List<int>();
    }

    // Método que pide al usuario ingresar 6 números ganadores
    public void IngresarNumeros()
    {
        Console.WriteLine("Ingrese 6 números ganadores:");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numerosGanadores.Add(numero);
        }
    }

    // Método que ordena los números y los muestra por pantalla
    public void MostrarOrdenados()
    {
        numerosGanadores.Sort();
        Console.WriteLine("Números ordenados:");
        foreach (var numero in numerosGanadores)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}
