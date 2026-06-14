using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int divisor = 2;
        bool esPrimo = true;

        Console.WriteLine("=====================================");
        Console.WriteLine("          NÚMERO PRIMO");
        Console.WriteLine("=====================================");
        Console.Write("Ingrese un número entero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero <= 1)
        {
            esPrimo = false;
        }
        else
        {
            while (divisor < numero)
            {
                if (numero % divisor == 0)
                {
                    esPrimo = false;
                }
                divisor = divisor + 1;
            }
        }

        Console.WriteLine("-------------------------------------");
        if (esPrimo == true)
        {
            Console.WriteLine("El número " + numero + " sí es primo.");
        }
        else
        {
            Console.WriteLine("El número " + numero + " no es primo.");
        }
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
