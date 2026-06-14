using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int tipo;
        int boletosVendidos = 0;
        int boletosAdulto = 0;
        int boletosNino = 0;
        int totalCobrado = 0;
        string respuesta = "si";

        Console.WriteLine("=====================================");
        Console.WriteLine("       FERIA - RUEDA DE LA FORTUNA");
        Console.WriteLine("=====================================");
        Console.WriteLine("Boleto de adulto: Q15");
        Console.WriteLine("Boleto de niño: Q10");
        Console.WriteLine("El supervisor necesita llevar control");
        Console.WriteLine("de boletos vendidos y dinero cobrado.");
        Console.WriteLine("Presione una tecla para comenzar...");
        Console.ReadKey();

        while (respuesta == "si")
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("       FERIA - RUEDA DE LA FORTUNA");
            Console.WriteLine("=====================================");
            Console.WriteLine("Boletos vendidos: " + boletosVendidos);
            Console.WriteLine("Boletos de adulto: " + boletosAdulto);
            Console.WriteLine("Boletos de niño: " + boletosNino);
            Console.WriteLine("Total cobrado: Q" + totalCobrado);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ingrese 1 para boleto de adulto.");
            Console.WriteLine("Ingrese 2 para boleto de niño.");
            Console.Write("Tipo de boleto: ");
            tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                boletosAdulto = boletosAdulto + 1;
                boletosVendidos = boletosVendidos + 1;
                totalCobrado = totalCobrado + 15;
                Console.WriteLine("Boleto de adulto vendido correctamente.");
            }
            else
            {
                if (tipo == 2)
                {
                    boletosNino = boletosNino + 1;
                    boletosVendidos = boletosVendidos + 1;
                    totalCobrado = totalCobrado + 10;
                    Console.WriteLine("Boleto de niño vendido correctamente.");
                }
                else
                {
                    Console.WriteLine("Opción no válida. No se vendió boleto.");
                }
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Boletos vendidos hasta ahora: " + boletosVendidos);
            Console.WriteLine("Total cobrado hasta ahora: Q" + totalCobrado);
            Console.Write("¿Desea vender otro boleto? (si/no): ");
            respuesta = Console.ReadLine().ToLower();
        }

        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("          RESUMEN FINAL");
        Console.WriteLine("=====================================");
        Console.WriteLine("Boletos de adulto vendidos: " + boletosAdulto);
        Console.WriteLine("Boletos de niño vendidos: " + boletosNino);
        Console.WriteLine("Total de boletos vendidos: " + boletosVendidos);
        Console.WriteLine("Total de dinero cobrado: Q" + totalCobrado);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
