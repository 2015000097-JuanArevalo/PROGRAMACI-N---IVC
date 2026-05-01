using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int actual = 21;

        Console.WriteLine("=====================================");
        Console.WriteLine("       IMPARES DESDE 20 HASTA N");
        Console.WriteLine("=====================================");
        Console.Write("Ingrese un número mayor que 20: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Números impares encontrados:");

        while (actual <= numero)
        {
            Console.WriteLine(actual);
            actual = actual + 2;
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Proceso finalizado.");
        Console.ReadKey();
    }
}
