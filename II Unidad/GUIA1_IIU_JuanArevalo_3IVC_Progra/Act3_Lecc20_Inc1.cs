internal class Program
{
    private static void Main(string[] args)
    {
        int dia;

        Console.Write("Ingrese un día de la semana: ");
        dia = int.Parse(Console.ReadLine());

        if (dia == 1||dia == 2|dia == 3|dia == 4|dia == 5)
            Console.WriteLine("Entre semana");
        else if (dia == 6||dia == 7)
            Console.WriteLine("Fin de semana");
        else
            Console.WriteLine("Acceso denegado");
    }
}