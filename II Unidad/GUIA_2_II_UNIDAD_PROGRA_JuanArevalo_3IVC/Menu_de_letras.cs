internal class Program
{
    private static void Main(string[] args)
    {
        string opc;
        Console.WriteLine("==== Menu Opciones ====");
        Console.WriteLine("A");
        Console.WriteLine("B");
        Console.WriteLine("C");
        Console.WriteLine("D");
        Console.WriteLine("F");
        Console.Write("Ingresa una opción: ");
        opc = Console.ReadLine();

        switch (opc)
        {
            case "A":
                Console.WriteLine("Excelente");
                break;
            case "B":
                Console.WriteLine("Bueno");
                break;
            case "C":
                Console.WriteLine("Regular");
                break;
            case "D":
                Console.WriteLine("Deficiente");
                break;
            case "F":
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Ingrese una opción válida.");
                break;
        }
    }
}