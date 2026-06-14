using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int contador;
        int factorial = 1;

        Console.WriteLine("=====================================");
        Console.WriteLine("       FACTORIAL DE UN NÚMERO");
        Console.WriteLine("=====================================");
        Console.WriteLine("El factorial se calcula multiplicando");
        Console.WriteLine("desde el número ingresado hasta llegar a 1.");
        Console.Write("Ingrese un número entero positivo: ");
        numero = int.Parse(Console.ReadLine());

        contador = numero;

        if (numero < 0)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("No se puede calcular factorial de un número negativo.");
        }
        else
        {
            if (numero == 0)
            {
                factorial = 1;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("0! = 1");
            }
            else
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Proceso del factorial:");

                do
                {
                    factorial = factorial * contador;
                    Console.WriteLine("Se multiplica por " + contador + ", resultado actual: " + factorial);
                    contador = contador - 1;
                } while (contador >= 1);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
