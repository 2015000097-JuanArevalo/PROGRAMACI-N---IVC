using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Conversiones===");

        Console.Write("Ingrese una cantidad en metros: ");
        double metros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Milimetros");
        Console.WriteLine("2. Centimetros");
        Console.WriteLine("3. Decimetros");
        Console.WriteLine("4. Hectometros");
        Console.WriteLine("5. Kilometros");
        Console.Write("Seleccione una opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        double resultado;
        string unidad;

        switch (opcion)
        {
            case 1:
                resultado = metros * 1000;
                unidad = "milimetros";
                break;
            case 2:
                resultado = metros * 100;
                unidad = "centimetros";
                break;
            case 3:
                resultado = metros * 10;
                unidad = "decimetros";
                break;
            case 4:
                resultado = metros / 100;
                unidad = "hectometros";
                break;
            case 5:
                resultado = metros / 1000;
                unidad = "kilometros";
                break;
            default:
                Console.WriteLine("Opcion invalida.");
                return;
        }

        Console.WriteLine($"{metros} metros equivale a {resultado} {unidad}.");
    }
}
