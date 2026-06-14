internal class Program
{
    private static void Main(string[] args)
    {
        int nota;

        Console.Write("Ingrese nota: ");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 70)
            Console.WriteLine("Aprobado");
        else
            Console.WriteLine("Reprobado");
    }
}