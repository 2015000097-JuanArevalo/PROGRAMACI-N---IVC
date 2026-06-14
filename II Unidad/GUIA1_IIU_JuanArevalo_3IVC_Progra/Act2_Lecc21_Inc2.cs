internal class Program
{
    private static void Main(string[] args)
    {
        int op;

        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1 Ventas");
        Console.WriteLine("2 Recepcion");
        Console.WriteLine("3 Direccion");
        Console.WriteLine("4 Compras");

        op = int.Parse(Console.ReadLine());

        if (op == 1)
            Console.WriteLine("Ventas - Juan Perez - ventas@empresa.com");
        else if (op == 2)
            Console.WriteLine("Recepcion - Ana Lopez - recepcion@empresa.com");
        else if (op == 3)
            Console.WriteLine("Direccion - Carlos Ruiz - direccion@empresa.com");
        else if (op == 4)
            Console.WriteLine("Compras - Maria Gomez - compras@empresa.com");
        else
            Console.WriteLine("Opcion invalida");
    }
}