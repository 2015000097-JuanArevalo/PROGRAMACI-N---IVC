using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int i;
        int multiplo;
        int suma = 0;
        int pares = 0;

        Console.WriteLine("=====================================");
        Console.WriteLine("   SUMA DE MÚLTIPLOS DE 7 Y PARES");
        Console.WriteLine("=====================================");

        for (i = 1; i <= 20; i++)
        {
            multiplo = 7 * i;
            suma = suma + multiplo;

            if (multiplo % 2 == 0)
            {
                pares = pares + 1;
            }

            Console.WriteLine("Múltiplo " + i + ": " + multiplo);
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Sumatoria de los 20 múltiplos de 7: " + suma);
        Console.WriteLine("Cantidad de esos números que son pares: " + pares);
        Console.ReadKey();
    }
}
