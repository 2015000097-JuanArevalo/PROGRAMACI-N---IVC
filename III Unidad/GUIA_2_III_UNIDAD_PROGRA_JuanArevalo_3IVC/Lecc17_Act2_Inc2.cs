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

int[,] matrizColumnas = new int[4, 4];

// Crear una matriz donde cada fila contiene 1, 2, 3 y 4
for (int fila = 0; fila < 4; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        matrizColumnas[fila, columna] = columna + 1;
    }
}

// Mostrar la matriz
Console.WriteLine("Matriz de columnas:");
for (int fila = 0; fila < 4; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        Console.Write(matrizColumnas[fila, columna] + "   ");
    }
    Console.WriteLine();
}
    }
}
