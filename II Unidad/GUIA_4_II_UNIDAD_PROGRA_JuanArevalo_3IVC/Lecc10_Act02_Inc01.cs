using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int i;

        Console.WriteLine("=====================================");
        Console.WriteLine("       PRIMEROS 20 MÚLTIPLOS DE 4");
        Console.WriteLine("=====================================");

        for (i = 1; i <= 20; i++)
        {
            Console.WriteLine("Múltiplo " + i + ": " + (4 * i));
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Proceso finalizado.");
        Console.ReadKey();
    }
}
