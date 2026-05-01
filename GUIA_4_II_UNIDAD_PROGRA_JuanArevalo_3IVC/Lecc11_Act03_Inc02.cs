using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int suma = 0;

        Console.WriteLine("=====================================");
        Console.WriteLine("       SUMA HASTA INGRESAR 0");
        Console.WriteLine("=====================================");
        Console.WriteLine("Ingrese números para sumarlos.");
        Console.WriteLine("Cuando ingrese 0, el programa termina.");

        do
        {
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            suma = suma + numero;
            Console.WriteLine("Suma actual: " + suma);
        } while (numero != 0);

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("La suma final es: " + suma);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
