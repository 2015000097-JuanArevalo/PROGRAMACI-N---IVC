using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int limite;
        int numero = 4;
        int producto;
        int suma = 0;

        Console.WriteLine("=====================================");
        Console.WriteLine("        SUMATORIA DE PRODUCTOS");
        Console.WriteLine("=====================================");
        Console.Write("Ingrese el último número de la serie: ");
        limite = int.Parse(Console.ReadLine());

        do
        {
            producto = numero * (numero - 1) * (numero - 2) * (numero - 3);
            suma = suma + producto;
            Console.WriteLine(numero + " x " + (numero - 1) + " x " + (numero - 2) + " x " + (numero - 3) + " = " + producto);
            numero = numero + 4;
        } while (numero <= limite);

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("La sumatoria es: " + suma);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
