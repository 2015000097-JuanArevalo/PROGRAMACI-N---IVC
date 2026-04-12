internal class Program
// Un programa que evalue un día en número
//y muestre el día en letras según el número
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DIAS DE LA SEMANA");
        //Variable
        int dia;
        //Solicitar el dato al usuario
        Console.Write("Dame un numero entero del 1 al 7: ");
        dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Digite un número entero entre el 1 y el 7");
                break;
        }
    }
}