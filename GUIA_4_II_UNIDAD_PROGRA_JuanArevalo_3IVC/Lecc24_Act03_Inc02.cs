using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int i;
        int suma = 0;

        Console.WriteLine("=====================================");
        Console.WriteLine("      SUMA REGRESIVA HASTA 1");
        Console.WriteLine("=====================================");
        Console.Write("Ingrese un número entero: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------");
        for (i = numero; i >= 1; i--)
        {
            suma = suma + i;
            Console.WriteLine(i);
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("La suma es: " + suma);
        Console.ReadKey();
    }
}
