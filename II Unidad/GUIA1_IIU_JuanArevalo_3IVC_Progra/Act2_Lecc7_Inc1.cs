internal class Program
{
    private static void Main(string[] args)
    {
        int op;

        Console.WriteLine("1 Ventas");
        Console.WriteLine("2 Recepcion");
        Console.WriteLine("3 Direccion");
        Console.WriteLine("4 Compras");

        op = int.Parse(Console.ReadLine());

        if (op == 1)
            Console.WriteLine("Bienvenido a Ventas");
        else if (op == 2)
            Console.WriteLine("Bienvenido a Recepcion");
        else if (op == 3)
            Console.WriteLine("Bienvenido a Direccion");
        else if (op == 4)
            Console.WriteLine("Bienvenido a Compras");
        else
            Console.WriteLine("Opcion invalida");
    }
}