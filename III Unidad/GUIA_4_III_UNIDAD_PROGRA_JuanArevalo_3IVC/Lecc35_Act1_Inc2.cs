internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Nombre: Juan Arévalo\nGrado: IVC - Clave: 3\n===CALCULADORA DE CAMBIO===");
        int pago, precio;
        string producto;
        Console.Write("DIgite el nombre del producto: ");
        producto = Console.ReadLine();
        Console.WriteLine("Digite el precio del producto: ");
        precio = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite el valor del billete con el que pagará: ");
        pago =  Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Menú Principal");
        Console.WriteLine("1. Milímetros\n2. Centímetros\n3. Decímetros\n4. Hectómetros\n5. Kilómetros\n6. Salir");
        Console.Write("Seleccione una opción: ");
        int opc = Convert.ToInt32(Console.ReadLine());

        int cambio = pago - precio;
        Console.WriteLine("Su cambio es: " + cambio);
    }
}