internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Juan Arévalo\nGrado: IVC - Clave: 3\n===CONVERSIONES===");
        double metros, resultado;
        Console.Write("Dame una medida en metros: ");
        metros = double.Parse(Console.ReadLine());

        Console.WriteLine("Menú Principal");
        Console.WriteLine("1. Milímetros\n2. Centímetros\n3. Decímetros\n4. Hectómetros\n5. Kilómetros\n6. Salir");
        Console.Write("Seleccione una opción: ");
        int opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Conversión a Milímetros");
                resultado = metros * 1000;
                Console.WriteLine("Los metros " + metros + " en milímetros son: " + resultado);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Conversión a Centímetros");
                resultado = metros * 100;
                Console.WriteLine("Los metros " + metros + " en centímetros son: " + resultado);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Conversión a Decímetros");
                resultado = metros * 10;
                Console.WriteLine("Los metros " + metros + " en decímetros son: " + resultado);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Conversión a Hectómetros");
                resultado = metros / 100;
                Console.WriteLine("Los metros " + metros + " en hectómetros son: " + resultado);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Conversión a Kilómetros");
                resultado = metros / 1000;
                Console.WriteLine("Los metros " + metros + " en kilómetros son: " + resultado);
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Para salir, presione una tecla...");
                Console.ReadKey();
                Console.WriteLine("Saliendo del sistema...");
                break;
            default:
                Console.WriteLine("Opción inválida...\nDigite una correcta.");
                break;
        }
    }
}