using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string respuesta;
        int boletosVendidos = 0;
        int dinero = 0;
        int disponibles = 15;

        Console.WriteLine("=====================================");
        Console.WriteLine("       BOLETOS PARA LA RUEDA");
        Console.WriteLine("=====================================");
        Console.WriteLine("Cada boleto cuesta Q10.");
        Console.WriteLine("Hay 15 espacios disponibles.");
        Console.WriteLine("Presione una tecla para comenzar...");
        Console.ReadKey();

        while (disponibles > 0)
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("       BOLETOS PARA LA RUEDA");
            Console.WriteLine("=====================================");
            Console.WriteLine("Boletos vendidos: " + boletosVendidos);
            Console.WriteLine("Espacios disponibles: " + disponibles);
            Console.WriteLine("Dinero acumulado: Q" + dinero);
            Console.Write("¿Desea vender un boleto? (si/no): ");
            respuesta = Console.ReadLine().ToLower();

            if (respuesta == "si")
            {
                boletosVendidos = boletosVendidos + 1;
                dinero = dinero + 10;
                disponibles = disponibles - 1;
                Console.WriteLine("Boleto vendido correctamente.");
            }
            else
            {
                disponibles = 0;
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine("=====================================");
        Console.WriteLine("          RESUMEN DE VENTA");
        Console.WriteLine("=====================================");
        Console.WriteLine("Boletos vendidos: " + boletosVendidos);
        Console.WriteLine("Total cobrado: Q" + dinero);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
