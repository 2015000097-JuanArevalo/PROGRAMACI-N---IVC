using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int tipo;
        int boletos = 0;
        int total = 0;
        string seguir;

        Console.WriteLine("=====================================");
        Console.WriteLine("       BOLETOS PARA LA RUEDA");
        Console.WriteLine("=====================================");
        Console.WriteLine("Adulto: Q15");
        Console.WriteLine("Niño: Q10");
        Console.WriteLine("-------------------------------------");

        do
        {
            Console.WriteLine("Ingrese 1 para adulto o 2 para niño:");
            tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                total = total + 15;
                boletos = boletos + 1;
                Console.WriteLine("Boleto de adulto vendido.");
            }
            else
            {
                if (tipo == 2)
                {
                    total = total + 10;
                    boletos = boletos + 1;
                    Console.WriteLine("Boleto de niño vendido.");
                }
                else
                {
                    Console.WriteLine("Tipo de boleto no válido.");
                }
            }

            Console.WriteLine("Boletos vendidos: " + boletos);
            Console.WriteLine("Total acumulado: Q" + total);
            Console.Write("¿Desea vender otro boleto? (si/no): ");
            seguir = Console.ReadLine().ToLower();
            Console.WriteLine("-------------------------------------");
        } while (seguir == "si");

        Console.WriteLine("=====================================");
        Console.WriteLine("          RESUMEN FINAL");
        Console.WriteLine("=====================================");
        Console.WriteLine("Boletos vendidos: " + boletos);
        Console.WriteLine("Total cobrado: Q" + total);
        Console.ReadKey();
    }
}
