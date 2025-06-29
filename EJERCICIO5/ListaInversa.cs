using System;
using System.Collections.Generic;

public class ListaInversa
{
    // Lista que almacena números del 1 al 10
    private List<int> numeros;

    // Constructor que llena la lista con números del 1 al 10
    public ListaInversa()
    {
        numeros = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }
    }

    // Método que invierte la lista y la muestra por pantalla separada por comas
    public void MostrarInverso()
    {
        numeros.Reverse();
        Console.WriteLine("Números en orden inverso:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}
