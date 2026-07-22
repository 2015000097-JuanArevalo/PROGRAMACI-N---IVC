using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Convertidor de Moneda===");

        const double dolar = 0.13;
        const double euro = 0.12;
        const double pesoMexicano = 2.30;
        const double lempira = 3.22;
        const double colonCostaRica = 65.00;

        string respuesta;

        do
        {
            Console.Write("Ingrese una cantidad en quetzales: Q");
            double quetzales = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Tasas de practica:");
            Console.WriteLine($"Estados Unidos - Dolares: {quetzales * dolar:F2}");
            Console.WriteLine($"Union Europea - Euros: {quetzales * euro:F2}");
            Console.WriteLine($"Mexico - Pesos: {quetzales * pesoMexicano:F2}");
            Console.WriteLine($"Honduras - Lempiras: {quetzales * lempira:F2}");
            Console.WriteLine($"Costa Rica - Colones: {quetzales * colonCostaRica:F2}");

            Console.Write("Desea convertir otra cantidad? (S/N): ");
            respuesta = Console.ReadLine().ToUpper();

        } while (respuesta == "S");
    }
}
