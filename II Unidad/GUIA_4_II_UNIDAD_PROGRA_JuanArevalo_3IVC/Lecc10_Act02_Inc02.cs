using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int i;

        Console.WriteLine("=====================================");
        Console.WriteLine("       PARES DESDE 2 HASTA N");
        Console.WriteLine("=====================================");
        Console.Write("Ingrese un número mayor que 2: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------");
        for (i = 2; i <= numero; i = i + 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Proceso finalizado.");
        Console.ReadKey();
    }
}
