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

string[,] donas = new string[2, 4];

// Fila 1
donas[0, 0] = "Chocolate";
donas[0, 1] = "Fresa";
donas[0, 2] = "Vainilla";
donas[0, 3] = "Chicle";

// Fila 2
donas[1, 0] = "Caramelo";
donas[1, 1] = "Café";
donas[1, 2] = "Coco";
donas[1, 3] = "Queque";

// Mostrar los datos
for (int fila = 0; fila < 2; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        Console.Write(donas[fila, columna] + "   |   ");
    }
    Console.WriteLine();
}
    }
}
