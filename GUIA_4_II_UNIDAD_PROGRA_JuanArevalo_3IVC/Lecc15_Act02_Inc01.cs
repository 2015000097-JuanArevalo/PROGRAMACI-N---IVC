using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int divisor;
        int contadorPrimos = 0;
        bool esPrimo;

        Console.WriteLine("=====================================");
        Console.WriteLine("       PRIMOS ENTRE 1 Y 10");
        Console.WriteLine("=====================================");
        Console.WriteLine("Números primos encontrados:");

        for (numero = 1; numero <= 10; numero++)
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
                contadorPrimos = contadorPrimos + 1;
            }
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Cantidad de primos: " + contadorPrimos);
        Console.ReadKey();
    }
}
