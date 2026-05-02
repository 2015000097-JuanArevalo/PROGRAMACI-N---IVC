using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int tipo;
        int boletos = 0;
        int boletosNino = 0;
        int boletosAdulto = 0;
        int total = 0;
        string seguir;

        Console.WriteLine("=====================================");
        Console.WriteLine("       BOLETOS PARA LA RUEDA");
        Console.WriteLine("=====================================");
        Console.WriteLine("Niño: Q10");
        Console.WriteLine("Adulto: Q15");
        Console.WriteLine("En cada venta ingrese 1 si es niño");
        Console.WriteLine("o ingrese 2 si es adulto.");
        Console.WriteLine("Presione una tecla para comenzar...");
        Console.ReadKey();

        do
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("       BOLETOS PARA LA RUEDA");
            Console.WriteLine("=====================================");
            Console.WriteLine("Boletos vendidos: " + boletos);
            Console.WriteLine("Boletos de niño: " + boletosNino);
            Console.WriteLine("Boletos de adulto: " + boletosAdulto);
            Console.WriteLine("Total acumulado: Q" + total);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ingrese 1 para niño.");
            Console.WriteLine("Ingrese 2 para adulto.");
            Console.Write("Tipo de boleto: ");
            tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                total = total + 10;
                boletos = boletos + 1;
                boletosNino = boletosNino + 1;
                Console.WriteLine("Boleto de niño vendido.");
            }
            else
            {
                if (tipo == 2)
                {
                    total = total + 15;
                    boletos = boletos + 1;
                    boletosAdulto = boletosAdulto + 1;
                    Console.WriteLine("Boleto de adulto vendido.");
                }
                else
                {
                    Console.WriteLine("Tipo de boleto no válido.");
                }
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Boletos vendidos hasta ahora: " + boletos);
            Console.WriteLine("Total acumulado hasta ahora: Q" + total);
            Console.Write("¿Desea vender otro boleto? (si/no): ");
            seguir = Console.ReadLine().ToLower();
        } while (seguir == "si");

        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("          RESUMEN FINAL");
        Console.WriteLine("=====================================");
        Console.WriteLine("Boletos de niño vendidos: " + boletosNino);
        Console.WriteLine("Boletos de adulto vendidos: " + boletosAdulto);
        Console.WriteLine("Boletos vendidos: " + boletos);
        Console.WriteLine("Total cobrado: Q" + total);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
