using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Agenda Telefonica===");

        string[] nombres = new string[10];
        string[] telefonos = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Persona " + (i + 1));

            Console.Write("Nombre: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Telefono: ");
            telefonos[i] = Console.ReadLine();

            Console.WriteLine();
        }

        Console.Write("Ingrese una posicion de la lista (1-10): ");
        int posicion = Convert.ToInt32(Console.ReadLine());

        if (posicion >= 1 && posicion <= 10)
        {
            int indice = posicion - 1;
            Console.WriteLine("Nombre: " + nombres[indice]);
            Console.WriteLine("Telefono: " + telefonos[indice]);
        }
        else
        {
            Console.WriteLine("Posicion invalida.");
        }
    }
}
