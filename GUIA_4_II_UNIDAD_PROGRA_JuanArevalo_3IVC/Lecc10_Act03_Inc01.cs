using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int divisor;
        bool esPrimo;

        Console.WriteLine("=====================================");
        Console.WriteLine("       PRIMOS ENTRE 1 Y 22");
        Console.WriteLine("=====================================");

        for (numero = 1; numero <= 22; numero++)
        {
            esPrimo = true;

            if (numero <= 1)
            {
                esPrimo = false;
            }

            for (divisor = 2; divisor < numero; divisor++)
            {
                if (numero % divisor == 0)
                {
                    esPrimo = false;
                }
            }

            if (esPrimo == true)
            {
                Console.WriteLine(numero);
            }
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Proceso finalizado.");
        Console.ReadKey();
    }
}
