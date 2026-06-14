using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int suma = 0;

        Console.WriteLine("=====================================");
        Console.WriteLine("       SUMA HASTA INGRESAR 9");
        Console.WriteLine("=====================================");
        Console.WriteLine("Ingrese números para sumarlos uno por uno.");
        Console.WriteLine("Cuando ingrese 9, el programa termina.");
        Console.WriteLine("Presione una tecla para comenzar...");
        Console.ReadKey();

        do
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("       SUMA HASTA INGRESAR 9");
            Console.WriteLine("=====================================");
            Console.WriteLine("Suma actual: " + suma);
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 9)
            {
                suma = suma + numero;
                Console.WriteLine("Número agregado a la suma.");
                Console.WriteLine("Nueva suma: " + suma);
            }
            else
            {
                Console.WriteLine("Se ingresó 9, el ciclo termina.");
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        } while (numero != 9);

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("La suma final es: " + suma);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
