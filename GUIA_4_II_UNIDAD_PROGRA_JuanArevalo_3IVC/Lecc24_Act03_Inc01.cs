using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int divisor;
        int suma = 0;
        bool esPrimo;

        Console.WriteLine("=====================================");
        Console.WriteLine("   SUMA DE PRIMOS ENTRE 1 Y 50");
        Console.WriteLine("=====================================");
        Console.WriteLine("Primos encontrados:");

        for (numero = 1; numero <= 50; numero++)
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
                suma = suma + numero;
            }
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("La suma de los primos es: " + suma);
        Console.ReadKey();
    }
}
