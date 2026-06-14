//Juan Ignacio Arévalo Toc IV "C" Clave: 3
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Juan Ignacio Arévalo Toc IVC Clave: 3");
        int[] edadesPersonas = new int[7];
        int cantidadMayoresEdad = 0;

        for (int indice = 0; indice < 7; indice++)
        {
            Console.Write("Ingrese la edad de la persona " + (indice + 1) + ": ");
            edadesPersonas[indice] = int.Parse(Console.ReadLine());

            if (edadesPersonas[indice] >= 18)
            {
                cantidadMayoresEdad = cantidadMayoresEdad + 1;
            }
        }

        Console.WriteLine("Cantidad de personas mayores de edad: " + cantidadMayoresEdad);

        Console.ReadKey();
    }
}
