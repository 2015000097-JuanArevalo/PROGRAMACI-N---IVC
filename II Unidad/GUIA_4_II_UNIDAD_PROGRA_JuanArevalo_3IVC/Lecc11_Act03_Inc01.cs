using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero1, numero2;
        int menor, mayor;
        int actual;
        int suma = 0;

        Console.WriteLine("=====================================");
        Console.WriteLine("      SUMA ENTRE DOS NÚMEROS");
        Console.WriteLine("=====================================");
        Console.Write("Ingrese el primer número: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        numero2 = int.Parse(Console.ReadLine());

        if (numero1 < numero2)
        {
            menor = numero1;
            mayor = numero2;
        }
        else
        {
            menor = numero2;
            mayor = numero1;
        }

        actual = menor;
        do
        {
            suma = suma + actual;
            actual = actual + 1;
        } while (actual <= mayor);

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Número menor: " + menor);
        Console.WriteLine("Número mayor: " + mayor);
        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
