using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Juan Arévalo");
        Console.WriteLine("Grado y Sección: IVC");
        Console.WriteLine("Clave: 3");
        Console.WriteLine("Ejemplo de una matriz");
        Console.WriteLine();

int[,] tabla = new int[4, 3];

// Ingresar datos y calcular la suma de cada fila
for (int fila = 0; fila < 4; fila++)
{
    int suma = 0;

    for (int columna = 0; columna < 3; columna++)
    {
        Console.Write("Ingrese un número para la fila " + (fila + 1) + ", columna " + (columna + 1) + ": ");
        tabla[fila, columna] = int.Parse(Console.ReadLine());
        suma += tabla[fila, columna];
    }

    Console.WriteLine("La suma de la fila " + (fila + 1) + " es: " + suma);
}
    }
}
