using System;

class Program
{
    static string NombreOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                return "Piedra";
            case 2:
                return "Papel";
            case 3:
                return "Tijeras";
            default:
                return "Opcion invalida";
        }
    }

    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Piedra, Papel o Tijeras===");

        Random aleatorio = new Random();
        string respuesta;

        do
        {
            Console.WriteLine("1. Piedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tijeras");
            Console.Write("Seleccione una opcion: ");
            int usuario = Convert.ToInt32(Console.ReadLine());

            if (usuario < 1 || usuario > 3)
            {
                Console.WriteLine("Opcion invalida.");
            }
            else
            {
                int computadora = aleatorio.Next(1, 4);

                Console.WriteLine("Usted eligio: " + NombreOpcion(usuario));
                Console.WriteLine("La computadora eligio: " + NombreOpcion(computadora));

                if (usuario == computadora)
                {
                    Console.WriteLine("Resultado: Empate.");
                }
                else if ((usuario == 1 && computadora == 3) ||
                         (usuario == 2 && computadora == 1) ||
                         (usuario == 3 && computadora == 2))
                {
                    Console.WriteLine("Resultado: Usted gana.");
                }
                else
                {
                    Console.WriteLine("Resultado: La computadora gana.");
                }
            }

            Console.Write("Desea jugar de nuevo? (S/N): ");
            respuesta = Console.ReadLine().ToUpper();

        } while (respuesta == "S");
    }
}
