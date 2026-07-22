using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Calculadora de Cambio===");

        Console.Write("Ingrese el precio del producto en quetzales enteros: Q");
        int precio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el valor del billete recibido: Q");
        int pago = Convert.ToInt32(Console.ReadLine());

        if (precio < 0 || pago < 0)
        {
            Console.WriteLine("Los valores no pueden ser negativos.");
            return;
        }

        if (pago < precio)
        {
            Console.WriteLine("El pago es insuficiente.");
            return;
        }

        int cambio = pago - precio;
        int restante = cambio;

        int billetes200 = restante / 200;
        restante = restante % 200;

        int billetes100 = restante / 100;
        restante = restante % 100;

        int billetes50 = restante / 50;
        restante = restante % 50;

        int billetes20 = restante / 20;
        restante = restante % 20;

        int monedas = restante;

        Console.WriteLine("Cambio total: Q" + cambio);
        Console.WriteLine("Billetes de Q200: " + billetes200);
        Console.WriteLine("Billetes de Q100: " + billetes100);
        Console.WriteLine("Billetes de Q50: " + billetes50);
        Console.WriteLine("Billetes de Q20: " + billetes20);
        Console.WriteLine("Monedas de Q1: " + monedas);
    }
}
