using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int divisor;
        int sumaPrimos = 0;
        int cantidadPrimos = 0;
        bool esPrimo;

        Console.WriteLine("=====================================");
        Console.WriteLine("       PRIMOS ENTRE 1 Y 100");
        Console.WriteLine("=====================================");
        Console.WriteLine("Se mostrarán los números primos y al final");
        Console.WriteLine("se mostrará la suma de todos ellos.");
        Console.WriteLine("Presione una tecla para comenzar...");
        Console.ReadKey();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Números primos encontrados:");

        for (numero = 1; numero <= 100; numero++)
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
                sumaPrimos = sumaPrimos + numero;
                cantidadPrimos = cantidadPrimos + 1;
            }
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Cantidad de primos encontrados: " + cantidadPrimos);
        Console.WriteLine("Suma de los primos: " + sumaPrimos);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
