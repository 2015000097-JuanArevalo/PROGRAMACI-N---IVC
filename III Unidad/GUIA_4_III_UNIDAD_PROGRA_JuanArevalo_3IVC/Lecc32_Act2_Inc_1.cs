using System;

class Program
{
    static string ObtenerSigno(int mes, int dia)
    {
        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
            return "Aries";
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
            return "Tauro";
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
            return "Geminis";
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
            return "Cancer";
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
            return "Leo";
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
            return "Virgo";
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
            return "Libra";
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
            return "Escorpio";
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
            return "Sagitario";
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
            return "Capricornio";
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
            return "Acuario";
        else
            return "Piscis";
    }

    static string ObtenerHoroscopo(string signo)
    {
        switch (signo)
        {
            case "Aries":
                return "Hoy tendras energia para iniciar algo nuevo.";
            case "Tauro":
                return "La paciencia te ayudara a tomar una buena decision.";
            case "Geminis":
                return "Una conversacion importante aclarara tus dudas.";
            case "Cancer":
                return "Dedica tiempo a tu familia y a descansar.";
            case "Leo":
                return "Tu confianza te ayudara a superar un reto.";
            case "Virgo":
                return "Organiza tus pendientes y avanzaras con facilidad.";
            case "Libra":
                return "Busca equilibrio antes de tomar una decision.";
            case "Escorpio":
                return "Confia en tu intuicion, pero piensa antes de actuar.";
            case "Sagitario":
                return "Una nueva idea puede convertirse en una oportunidad.";
            case "Capricornio":
                return "Tu esfuerzo constante dara buenos resultados.";
            case "Acuario":
                return "Comparte tus ideas y escucha otras opiniones.";
            default:
                return "Hoy sera un buen dia para aprender algo nuevo.";
        }
    }

    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Horoscopo===");

        Console.Write("Ingrese el mes de nacimiento (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el dia de nacimiento: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        if (mes < 1 || mes > 12 || dia < 1 || dia > 31)
        {
            Console.WriteLine("Fecha invalida.");
            return;
        }

        string signo = ObtenerSigno(mes, dia);
        string horoscopo = ObtenerHoroscopo(signo);

        Console.WriteLine("Su signo zodiacal es: " + signo);
        Console.WriteLine("Horoscopo: " + horoscopo);
    }
}
