//Juan Ignacio Arévalo Toc IV "C" Clave: 3
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Juan Ignacio Arévalo Toc IVC Clave: 3");
        int[] numerosEnteros = new int[15];
        bool existeRepetido = false;

        for (int indice = 0; indice < 15; indice++)
        {
            Console.Write("Ingrese el número " + (indice + 1) + ": ");
            numerosEnteros[indice] = int.Parse(Console.ReadLine());
        }

        for (int indice = 0; indice < 14; indice++)
        {
            for (int comparador = indice + 1; comparador < 15; comparador++)
            {
                if (numerosEnteros[indice] == numerosEnteros[comparador])
                {
                    existeRepetido = true;
                }
            }
        }

        if (existeRepetido)
        {
            Console.WriteLine("Sí existe al menos un número repetido.");
        }
        else
        {
            Console.WriteLine("No existe ningún número repetido.");
        }

        Console.ReadKey();
    }
}
