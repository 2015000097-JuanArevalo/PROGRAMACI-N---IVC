using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int monedas = 0;
        int ganadas;

        Console.WriteLine("=====================================");
        Console.WriteLine("       DESBLOQUEO DEL NIVEL 5");
        Console.WriteLine("=====================================");
        Console.WriteLine("Necesitas 350 monedas para entrar.");
        Console.WriteLine("Presione una tecla para comenzar...");
        Console.ReadKey();

        while (monedas < 350)
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("       DESBLOQUEO DEL NIVEL 5");
            Console.WriteLine("=====================================");
            Console.WriteLine("Monedas actuales: " + monedas);
            Console.WriteLine("Monedas faltantes: " + (350 - monedas));
            Console.WriteLine("El nivel sigue bloqueado.");
            Console.Write("Ingrese las monedas ganadas en esta partida: ");
            ganadas = int.Parse(Console.ReadLine());

            monedas = monedas + ganadas;

            Console.WriteLine("Ahora tienes " + monedas + " monedas.");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("          NIVEL DESBLOQUEADO");
        Console.WriteLine("=====================================");
        Console.WriteLine("Ya tienes " + monedas + " monedas.");
        Console.WriteLine("Puedes ingresar al nivel 5.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
