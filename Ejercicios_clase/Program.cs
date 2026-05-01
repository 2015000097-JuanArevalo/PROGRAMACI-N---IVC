//Un programa que solicite al usuario un valor numérico
//Mostrar en pantalla si es positivo o negativo
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Numeros Positivos y Negativos");
        //Variables
        int num;
        num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0)
            Console.WriteLine("Soy un número POSITIVO");
        else
            Console.WriteLine("Soy un número NEGATIVO");
    }
}