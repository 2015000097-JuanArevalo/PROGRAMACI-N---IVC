internal class Program
{
    private static void Main(string[] args)
    {
        int dia, mes;

        Console.Write("Ingrese dia: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese mes: ");
        mes = int.Parse(Console.ReadLine());

        if ((mes == 12 && dia >= 21) || (mes == 1) || (mes == 2) || (mes == 3 && dia <= 20))
            Console.WriteLine("Invierno");
        else if ((mes == 3 && dia >= 21) || (mes == 4) || (mes == 5) || (mes == 6 && dia <= 20))
            Console.WriteLine("Primavera");
        else if ((mes == 6 && dia >= 21) || (mes == 7) || (mes == 8) || (mes == 9 && dia <= 22))
            Console.WriteLine("Verano");
        else if ((mes == 9 && dia >= 23) || (mes == 10) || (mes == 11) || (mes == 12 && dia <= 20))
            Console.WriteLine("Otoño");
        else
            Console.WriteLine("Fecha inválida");
    }
}