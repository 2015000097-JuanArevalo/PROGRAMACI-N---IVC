using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int contador = 1;

        Console.WriteLine("=====================================");
        Console.WriteLine("          TABLA DE MULTIPLICAR");
        Console.WriteLine("=====================================");
        Console.Write("Ingrese el número de la tabla: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------");
        while (contador <= 10)
        {
            Console.WriteLine(numero + " x " + contador + " = " + (numero * contador));
            contador = contador + 1;
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Tabla terminada.");
        Console.ReadKey();
    }
}
