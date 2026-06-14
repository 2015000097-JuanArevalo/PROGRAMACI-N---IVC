using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int i;

        Console.WriteLine("=====================================");
        Console.WriteLine("    20 MÚLTIPLOS DE UN NÚMERO");
        Console.WriteLine("=====================================");
        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------");
        for (i = 1; i <= 20; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Proceso finalizado.");
        Console.ReadKey();
    }
}
