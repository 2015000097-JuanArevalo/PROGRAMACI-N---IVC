internal class Program
{
    private static void Main(string[] args)
    {
        int dia;

        Console.Write("Ingrese un numero del 1 al 7: ");
        dia = int.Parse(Console.ReadLine());

        if (dia == 1)
            Console.WriteLine("Hoy es Lunes");
        else if (dia == 2)
            Console.WriteLine("Hoy es Martes");
        else if (dia == 3)
            Console.WriteLine("Hoy es Miercoles");
        else if (dia == 4)
            Console.WriteLine("Hoy es Jueves");
        else if (dia == 5)
            Console.WriteLine("Hoy es Viernes");
        else if (dia == 6)
            Console.WriteLine("Hoy es Sabado");
        else if (dia == 7)
            Console.WriteLine("Hoy es Domingo");
        else
            Console.WriteLine("Numero invalido");
    }
}