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
                suma += numero;
            }
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Suma de los números primos entre 1 y 22: "+ suma);
        Console.WriteLine("Proceso finalizado.");
        Console.ReadKey();
    }
}
