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

int[,] matrizIdentidad = new int[4, 4];

// Crear la matriz identidad de 4 x 4
for (int fila = 0; fila < 4; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        if (fila == columna)
        {
            matrizIdentidad[fila, columna] = 1;
        }
        else
        {
            matrizIdentidad[fila, columna] = 0;
        }
    }
}

// Mostrar la matriz
Console.WriteLine("Matriz identidad:");
for (int fila = 0; fila < 4; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        Console.Write(matrizIdentidad[fila, columna] + "   ");
    }
    Console.WriteLine();
}
    }
}
