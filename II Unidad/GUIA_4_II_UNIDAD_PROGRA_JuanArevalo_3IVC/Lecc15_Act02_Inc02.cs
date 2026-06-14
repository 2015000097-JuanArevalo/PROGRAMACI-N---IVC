using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int contador = 1;
        int denominacion;
        int cantidad100 = 0;
        int totalDinero = 0;

        Console.WriteLine("=====================================");
        Console.WriteLine("        FAJO DE MIL BILLETES");
        Console.WriteLine("=====================================");
        Console.WriteLine("El cajero revisará 1000 billetes.");
        Console.WriteLine("Las denominaciones válidas son Q20, Q50 y Q100.");
        Console.WriteLine("Se contará cuántos billetes son de Q100");
        Console.WriteLine("y cuánto dinero hay en total.");
        Console.WriteLine("Presione una tecla para comenzar...");
        Console.ReadKey();

        do
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("        FAJO DE MIL BILLETES");
            Console.WriteLine("=====================================");
            Console.WriteLine("Billete revisado: " + contador + " de 1000");
            Console.WriteLine("Billetes de Q100 encontrados: " + cantidad100);
            Console.WriteLine("Total acumulado: Q" + totalDinero);
            Console.WriteLine("-------------------------------------");
            Console.Write("Ingrese denominación del billete (20, 50 o 100): ");
            denominacion = int.Parse(Console.ReadLine());

            if (denominacion == 20 || denominacion == 50 || denominacion == 100)
            {
                totalDinero = totalDinero + denominacion;

                if (denominacion == 100)
                {
                    cantidad100 = cantidad100 + 1;
                }

                Console.WriteLine("Billete registrado correctamente.");
                contador = contador + 1;
            }
            else
            {
                Console.WriteLine("Denominación no válida. Debe ser 20, 50 o 100.");
                Console.WriteLine("Este billete no se contará, intente otra vez.");
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        } while (contador <= 1000);

        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("          RESUMEN FINAL");
        Console.WriteLine("=====================================");
        Console.WriteLine("Billetes revisados: 1000");
        Console.WriteLine("Billetes de Q100: " + cantidad100);
        Console.WriteLine("Total de dinero en el fajo: Q" + totalDinero);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
