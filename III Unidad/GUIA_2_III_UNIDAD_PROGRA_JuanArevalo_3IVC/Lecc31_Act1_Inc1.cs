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

int fila = 3;
int columna = 5;
int[,] matriz = new int[fila, columna];

// Ingresar los datos de la matriz
for (int i = 0; i < fila; i++)
{
    for (int j = 0; j < columna; j++)
    {
        Console.Write("Ingrese el número que quiere guardar en la fila " + i + ", columna " + j + " = ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

// Mostrar los datos de la matriz
Console.WriteLine();
for (int i = 0; i < fila; i++)
{
    for (int j = 0; j < columna; j++)
    {
        Console.WriteLine("Fila: " + i + ", Columna: " + j + " = " + matriz[i, j]);
    }
}
    }
}
