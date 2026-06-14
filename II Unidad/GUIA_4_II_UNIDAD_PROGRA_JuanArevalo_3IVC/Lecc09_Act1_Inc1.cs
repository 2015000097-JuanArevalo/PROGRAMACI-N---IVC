internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----CONTADOR DE MANZANAS-----");
        int totman = 0;
        int totnet = 1000; // Tu meta de 1 kilo
        int cont = 0;
        int suma = 0;

        while (totman < totnet)
        {
            Console.WriteLine($"\nLlevas acumulado: {totman}g");
            Console.WriteLine("Ingresa cuantos gramos pesa tu manzana:");
            suma = int.Parse(Console.ReadLine());

            if (suma >= 180)
            {
                if (totman + suma <= totnet)
                {
                    totman = totman + suma;
                    cont++;
                    Console.WriteLine($"Correcto. Te faltan: {totnet - totman}g");
                    Console.WriteLine($"Llevas: {cont} manzanas");
                }
                else
                {
                    Console.WriteLine($"¡Error! Esta manzana de {suma}g hace que superes el kilo. No se contará.");
                    Console.WriteLine($"Intenta con una más pequeña. Te quedan {totnet - totman}g de espacio.");
                }
            }
            else
            {
                Console.WriteLine("¡Eso pesa muy poco para ser una manzana! Intenta de nuevo.");
            }
        }
        
        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("¡Ya has llegado al 1 kilo!");
        Console.WriteLine($"Llevas en total: {totman}g, que son {cont} manzanas.");
    }
}