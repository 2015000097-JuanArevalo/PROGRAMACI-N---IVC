internal class Program
{
    private static void Main(string[] args)
    {
        int grados, opc;

        Console.WriteLine("* CALCULADORA FUNCIONES TRIGONOMÉTRICAS BÁSICAS *");
        Console.WriteLine("*************************************************");
        Console.WriteLine("* Lista de funciones trigonométricas            *");
        Console.WriteLine("*  1- Seno                                      *");
        Console.WriteLine("*  2- Coseno                                    *");
        Console.WriteLine("*  3- Tangente                                  *");
        Console.WriteLine("*************************************************");

        Console.Write("Digite un ángulo en grados: ");
        grados = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite la opción: ");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("El seno de " + grados + "° es: " + Math.Sin(grados * Math.PI / 180.0));
                break;
            case 2:
                Console.WriteLine("El coseno de " + grados + "° es: " + Math.Cos(grados * Math.PI / 180.0));
                break;
            case 3:
                Console.WriteLine("La tangente de " + grados + "° es: " + Math.Tan(grados * Math.PI / 180.0));
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}