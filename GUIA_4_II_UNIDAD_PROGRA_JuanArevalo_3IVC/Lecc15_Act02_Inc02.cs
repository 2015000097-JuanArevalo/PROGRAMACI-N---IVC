using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double precio;
        double subtotal = 0;
        double iva;
        double total;
        int productos = 0;

        Console.WriteLine("=====================================");
        Console.WriteLine("        CAJERO DE SUPERMERCADO");
        Console.WriteLine("=====================================");
        Console.WriteLine("Ingrese los precios de los productos.");
        Console.WriteLine("Escriba 0 cuando ya no haya más productos.");

        do
        {
            Console.Write("Ingrese precio del producto: Q");
            precio = double.Parse(Console.ReadLine());

            if (precio > 0)
            {
                subtotal = subtotal + precio;
                productos = productos + 1;
                Console.WriteLine("Producto agregado. Subtotal actual: Q" + subtotal);
            }
        } while (precio != 0);

        iva = subtotal * 0.12;
        total = subtotal + iva;

        Console.WriteLine("=====================================");
        Console.WriteLine("           TOTAL DE COMPRA");
        Console.WriteLine("=====================================");
        Console.WriteLine("Productos ingresados: " + productos);
        Console.WriteLine("Venta sin impuesto: Q" + subtotal);
        Console.WriteLine("IVA 12%: Q" + iva);
        Console.WriteLine("Total a pagar: Q" + total);
        Console.ReadKey();
    }
}
