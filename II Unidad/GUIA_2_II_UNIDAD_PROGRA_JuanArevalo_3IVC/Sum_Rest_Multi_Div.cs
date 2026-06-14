using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2, resultado;
        int opcion;

        Console.WriteLine("==== CALCULADORA BÁSICA ====");

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1 - Sumar");
        Console.WriteLine("2 - Restar");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.Write("Seleccione una opción: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("La suma es: " + resultado);
                break;

            case 2:
                resultado = num1 - num2;
                Console.WriteLine("La resta es: " + resultado);
                break;

            case 3:
                resultado = num1 * num2;
                Console.WriteLine("La multiplicación es: " + resultado);
                break;

            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine("La división es: " + resultado);
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre 0.");
                }
                break;

            default:
                Console.WriteLine("ERROR AL OPERAR LOS NÚMEROS");
                break;
        }
    }
}
