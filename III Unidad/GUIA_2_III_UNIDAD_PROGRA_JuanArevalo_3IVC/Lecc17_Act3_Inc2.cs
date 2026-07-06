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

int[,] tabla = new int[4, 4];

// Ingresar los 16 datos en la matriz
for (int fila = 0; fila < 4; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        Console.Write("Ingrese un número para la fila " + (fila + 1) + ", columna " + (columna + 1) + ": ");
        tabla[fila, columna] = int.Parse(Console.ReadLine());
    }
}

// Tomar el primer dato como referencia
int mayor = tabla[0, 0];
int filaMayor = 0;
int columnaMayor = 0;

// Buscar el número mayor y guardar su posición
for (int fila = 0; fila < 4; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        if (tabla[fila, columna] > mayor)
        {
            mayor = tabla[fila, columna];
            filaMayor = fila;
            columnaMayor = columna;
        }
    }
}

// Mostrar el resultado final
Console.WriteLine("El número mayor es: " + mayor);
Console.WriteLine("Está en la fila: " + (filaMayor + 1));
Console.WriteLine("Y en la columna: " + (columnaMayor + 1));
    }
}
