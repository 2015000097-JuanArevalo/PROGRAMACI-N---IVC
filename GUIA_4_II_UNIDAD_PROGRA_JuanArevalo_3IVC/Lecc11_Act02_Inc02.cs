using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 2;

        Console.WriteLine("=====================================");
        Console.WriteLine("          PARES ENTRE 1 Y 100");
        Console.WriteLine("=====================================");

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
