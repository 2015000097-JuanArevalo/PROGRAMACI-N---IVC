using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Tipos de Triangulos===");

        Console.Write("Ingrese el primer lado: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
        {
            Console.WriteLine("Las medidas deben ser mayores que cero.");
        }
        else if (lado1 + lado2 <= lado3 ||
                 lado1 + lado3 <= lado2 ||
                 lado2 + lado3 <= lado1)
        {
            Console.WriteLine("Las medidas no forman un triangulo.");
        }
        else if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triangulo es equilatero.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triangulo es isosceles.");
        }
        else
        {
            Console.WriteLine("El triangulo es escaleno.");
        }
    }
}
