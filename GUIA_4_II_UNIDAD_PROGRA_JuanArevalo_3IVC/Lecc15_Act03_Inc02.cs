using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 300;
        int divisor;
        int cantidadPrimos = 0;
        int cantidadPares = 0;
        int sumaPares = 0;
        bool esPrimo;

        Console.WriteLine("=====================================");
        Console.WriteLine("  CUENTA REGRESIVA, PRIMOS Y PARES");
        Console.WriteLine("=====================================");

        while (numero >= 1)
        {
            if (numero % 2 == 0)
            {
                cantidadPares = cantidadPares + 1;
                sumaPares = sumaPares + numero;
            }

            esPrimo = true;
            if (numero <= 1)
            {
                esPrimo = false;
            }

            divisor = 2;
            while (divisor < numero)
            {
                if (numero % divisor == 0)
                {
                    esPrimo = false;
                }
                divisor = divisor + 1;
            }

            if (esPrimo == true)
            {
                cantidadPrimos = cantidadPrimos + 1;
            }

            numero = numero - 1;
        }

        Console.WriteLine("Cantidad de números primos entre 300 y 1: " + cantidadPrimos);
        Console.WriteLine("Cantidad de números pares entre 300 y 1: " + cantidadPares);
        Console.WriteLine("Suma de los pares: " + sumaPares);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
