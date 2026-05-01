internal class Program
{
    private static void Main(string[] args)
    {
        string opc;
        int cajOc = 0;
        const int capTot = 10;

        do {
            Console.WriteLine("-----SISTEMA DE ACCESO-----");
            Console.WriteLine("\nESTADO: {0} ocupados | {1} disponibles", cajOc, capTot - cajOc);
            Console.WriteLine("¿Ingresar nuevo vehículo (S/N)");
            opc = Console.ReadLine().ToUpper();

            if (opc == "S")
            {
                cajOc++;
                Console.WriteLine(">>Acceso concedido. Levantando talanquera...");
            }
            else if (opc != "N")
            {
                Console.WriteLine(">>Opción inválida. Use 'S' para sí o la 'N' para no.");
            }
        } while (opc != "N" && cajOc < capTot);

        if (cajOc >= capTot)
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("ALERTA: CUPO COMPLETADO, BARRERA BLOQUADA");
            Console.WriteLine("\n---------------------------");
        }
        Console.WriteLine("\nApagando el sistema de control.");
        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }
}