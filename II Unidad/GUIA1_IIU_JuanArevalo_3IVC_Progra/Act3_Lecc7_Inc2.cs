internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("Ingrese los 3 lados:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Equilatero");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Isosceles");
        else
            Console.WriteLine("Escaleno");
    }
}