internal class Program
{
    private static void Main(string[] args)
    {
        int opc;

        Console.WriteLine("==== Mes y Días ====");

        Console.WriteLine("********************");
        Console.WriteLine("* MENÚ DE OPCIONES *");
        Console.WriteLine("********************");
        Console.WriteLine("Enero - 1");
        Console.WriteLine("Febrero - 2");
        Console.WriteLine("Marzo - 3");
        Console.WriteLine("Abril - 4");
        Console.WriteLine("Mayo - 5");
        Console.WriteLine("Junio - 6");
        Console.WriteLine("Julio - 7");
        Console.WriteLine("Agosto - 8");
        Console.WriteLine("Septiembre - 9");
        Console.WriteLine("Octubre - 10");
        Console.WriteLine("Noviembre - 11");
        Console.WriteLine("Diciembre - 12");

        Console.Write("Digite la opción: ");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Enero: 31 días");
                break;
            case 2:
                Console.WriteLine("Febrero: 28/29 días");
                break;
            case 3:
                Console.WriteLine("Marzo: 31 días");
                break;
            case 4:
                Console.WriteLine("Abril: 30 días");
                break;
            case 5:
                Console.WriteLine("Mayo: 31 días");
                break;
            case 6:
                Console.WriteLine("Junio: 30 días");
                break;
            case 7:
                Console.WriteLine("Julio: 31 días");
                break;
            case 8:
                Console.WriteLine("Agosto: 31 días");
                break;
            case 9:
                Console.WriteLine("Septiembre: 30 días");
                break;
            case 10:
                Console.WriteLine("Octubre: 31 días");
                break;
            case 11:
                Console.WriteLine("Noviembre: 30 días");
                break;
            case 12:
                Console.WriteLine("Diciembre: 31 días");
                break;
            default:
                Console.WriteLine("OPCIÓN INVÁLIDA INGRESADA");
                break;
        }
    }
}