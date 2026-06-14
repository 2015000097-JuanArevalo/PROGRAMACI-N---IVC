using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 1;

        Console.WriteLine("=====================================");
        Console.WriteLine("       IMPARES ENTRE 1 Y 100");
        Console.WriteLine("=====================================");
        Console.WriteLine("El programa mostrará todos los impares.");
        Console.WriteLine("Presione una tecla para comenzar...");
        Console.ReadKey();

        Console.WriteLine("-------------------------------------");
        do
        {
            Console.WriteLine(numero);
            numero = numero + 2;
        } while (numero <= 100);

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Proceso finalizado.");
        Console.ReadKey();
    }
}
