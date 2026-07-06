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

int[,] edades = new int[3, 3];
string[,] estado = new string[3, 3];

// Ingresar la edad de cada estudiante
for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 3; columna++)
    {
        Console.Write("Ingrese la edad del estudiante en la fila " + (fila + 1) + ", columna " + (columna + 1) + ": ");
        edades[fila, columna] = int.Parse(Console.ReadLine());

        if (edades[fila, columna] >= 18)
        {
            estado[fila, columna] = "mayor";
        }
        else
        {
            estado[fila, columna] = "menor";
        }
    }
}

// Mostrar la matriz con edad y clasificación
Console.WriteLine();
Console.WriteLine("Matriz de edades:");
for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 3; columna++)
    {
        Console.Write(edades[fila, columna] + " - " + estado[fila, columna] + "   |   ");
    }
    Console.WriteLine();
}
    }
}
