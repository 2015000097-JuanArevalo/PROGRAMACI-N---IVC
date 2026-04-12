internal class Program
{
    private static void Main(string[] args)
    {
        int opc;

        Console.WriteLine("==== Menú de Restaurante ====");

        Console.WriteLine("********************");
        Console.WriteLine("* MENÚ DE OPCIONES *");
        Console.WriteLine("********************");
        Console.WriteLine("Hamburguesa - 1");
        Console.WriteLine("Pizza - 2");
        Console.WriteLine("Pollo frito - 3");
        Console.WriteLine("Ensalada - 4");

        Console.Write("Digite la opción: ");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Hamburguesa");
                break;
            case 2:
                Console.WriteLine("Pizza");
                break;
            case 3:
                Console.WriteLine("Pollo frito");
                break;
            case 4:
                Console.WriteLine("Ensalada");
                break;
            default:
                Console.WriteLine("OPCIÓN INVÁLIDA INGRESADA");
                break;
        }
    }
}