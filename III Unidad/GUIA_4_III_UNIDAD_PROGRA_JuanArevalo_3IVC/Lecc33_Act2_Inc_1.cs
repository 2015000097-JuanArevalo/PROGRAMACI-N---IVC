using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Frase Invertida===");

        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();
        string invertida = "";

        for (int i = frase.Length - 1; i >= 0; i--)
        {
            invertida = invertida + frase[i];
        }

        Console.WriteLine("Frase invertida: " + invertida);
    }
}
