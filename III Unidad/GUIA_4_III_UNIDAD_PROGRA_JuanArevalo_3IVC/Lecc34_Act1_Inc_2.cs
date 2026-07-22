using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Indice de Masa Corporal===");

        Console.Write("Ingrese el peso en kilogramos: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura en metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        if (peso <= 0 || altura <= 0)
        {
            Console.WriteLine("El peso y la altura deben ser mayores que cero.");
            return;
        }

        double imc = peso / (altura * altura);

        Console.WriteLine($"Su IMC es: {imc:F2}");
    }
}
