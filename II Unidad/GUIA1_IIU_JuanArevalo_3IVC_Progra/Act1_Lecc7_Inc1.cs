internal class Program
{
    //Un algoritmo que determine si un alumno aprueba o
    //reprueba una materia, basado en
    //el promedio de cinco calificaciones.
    private static void Main(string[] args)
    {
        Console.WriteLine("==PROMEDIO DE CALIFICACIONES==");
        //Variables
        string materia;
        int n1, n2, n3 , n4, n5;
        double promedio;
        //Enviar información al usuario
        Console.WriteLine("Digite una materia:");
        materia = Console.ReadLine();
        Console.WriteLine("Dame 5 notas:");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());
        n5 = Convert.ToInt32(Console.ReadLine());
        //Proceso
        promedio = (n1+n2+n3+n4+n5)/5;
        //Evaluar si ganó o perdió
        if (promedio >= 70)
            Console.WriteLine("El promedio es: " + promedio + " y el estudiante aprobó.");
        else
            Console.WriteLine("El promedio es: " + promedio + " y el estudiante reprobó.");
    }
}