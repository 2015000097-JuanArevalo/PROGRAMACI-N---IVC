internal class Program
{
    private static void Main(string[] args)
    {
        int opc1, cantidad;
        double precio;

        Console.WriteLine("==== Entradas Estadio Doroteo Guamuch Flores ====");

        Console.WriteLine("********************");
        Console.WriteLine("* MENÚ DE OPCIONES *");
        Console.WriteLine("********************");
        Console.WriteLine("1- Palco: Q300.00");
        Console.WriteLine("2- Tribuna: Q100.00 - Q125.00");
        Console.WriteLine("3- Preferencia: Q50.00 - Q75.00");
        Console.WriteLine("4- Generales: Q30.00 - Q50.00");
        Console.WriteLine("********************");

        Console.Write("Ingrese una opción: ");
        opc1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad de entradas: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        switch (opc1)
        {
            case 1:
                precio = 300.00;
                Console.WriteLine("Sector elegido: Palco");
                Console.WriteLine("Cantidad de entradas: " + cantidad);
                Console.WriteLine("Precio: Q. " + precio);
                Console.WriteLine("Total a pagar: Q. " + (cantidad * precio));
                break;

            case 2:
                Console.Write("Ingrese el precio de la entrada en Tribuna (Q. 100.00 a Q. 125.00): ");
                precio = Convert.ToDouble(Console.ReadLine());

                if (precio >= 100 && precio <= 125)
                {
                    Console.WriteLine("Sector elegido: Tribuna");
                    Console.WriteLine("Cantidad de entradas: " + cantidad);
                    Console.WriteLine("Precio: Q. " + precio);
                    Console.WriteLine("Total a pagar: Q. " + (cantidad * precio));
                }
                else
                {
                    Console.WriteLine("Precio no válido para Tribuna.");
                }
                break;

            case 3:
                Console.Write("Ingrese el precio de la entrada en Preferencia (Q. 50.00 a Q. 75.00): ");
                precio = Convert.ToDouble(Console.ReadLine());

                if (precio >= 50 && precio <= 75)
                {
                    Console.WriteLine("Sector elegido: Preferencia");
                    Console.WriteLine("Cantidad de entradas: " + cantidad);
                    Console.WriteLine("Precio: Q. " + precio);
                    Console.WriteLine("Total a pagar: Q. " + (cantidad * precio));
                }
                else
                {
                    Console.WriteLine("Precio no válido para Preferencia.");
                }
                break;

            case 4:
                Console.Write("Ingrese el precio de la entrada en Generales (Q. 30.00 a Q. 50.00): ");
                precio = Convert.ToDouble(Console.ReadLine());

                if (precio >= 30 && precio <= 50)
                {
                    Console.WriteLine("Sector elegido: Generales");
                    Console.WriteLine("Cantidad de entradas: " + cantidad);
                    Console.WriteLine("Precio: Q. " + precio);
                    Console.WriteLine("Total a pagar: Q. " + (cantidad * precio));
                }
                else
                {
                    Console.WriteLine("Precio no válido para Generales.");
                }
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}