internal class Program
{
    private static void Main(string[] args)
    {
        char opc1, opc2;
        double cantidad, resultado;

        Console.WriteLine("==== Conversor de medidas de longitud ====");

        Console.WriteLine("********************");
        Console.WriteLine("* MENÚ DE OPCIONES *");
        Console.WriteLine("********************");
        Console.WriteLine("a) Metros");
        Console.WriteLine("b) Pies");
        Console.WriteLine("c) Centímetros");
        Console.WriteLine("d) Pulgadas");
        Console.WriteLine("********************");

        Console.Write("Seleccione la unidad que quiere convertir: ");
        opc1 = Convert.ToChar(Console.ReadLine().ToLower());

        Console.Write("Seleccione la unidad a la que quiere convertir: ");
        opc2 = Convert.ToChar(Console.ReadLine().ToLower());

        Console.Write("Ingrese la cantidad: ");
        cantidad = Convert.ToDouble(Console.ReadLine());

        switch (opc1)
        {
            case 'a':
                switch (opc2)
                {
                    case 'a':
                        resultado = cantidad;
                        Console.WriteLine("Resultado: " + resultado + " m");
                        break;
                    case 'b':
                        resultado = cantidad * 3.28084;
                        Console.WriteLine("Resultado: " + resultado + " pies");
                        break;
                    case 'c':
                        resultado = cantidad * 100;
                        Console.WriteLine("Resultado: " + resultado + " cm");
                        break;
                    case 'd':
                        resultado = cantidad * 39.3701;
                        Console.WriteLine("Resultado: " + resultado + " pulg");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                break;

            case 'b':
                switch (opc2)
                {
                    case 'a':
                        resultado = cantidad / 3.28084;
                        Console.WriteLine("Resultado: " + resultado + " m");
                        break;
                    case 'b':
                        resultado = cantidad;
                        Console.WriteLine("Resultado: " + resultado + " pies");
                        break;
                    case 'c':
                        resultado = cantidad * 30.48;
                        Console.WriteLine("Resultado: " + resultado + " cm");
                        break;
                    case 'd':
                        resultado = cantidad * 12;
                        Console.WriteLine("Resultado: " + resultado + " pulg");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                break;

            case 'c':
                switch (opc2)
                {
                    case 'a':
                        resultado = cantidad / 100;
                        Console.WriteLine("Resultado: " + resultado + " m");
                        break;
                    case 'b':
                        resultado = cantidad / 30.48;
                        Console.WriteLine("Resultado: " + resultado + " pies");
                        break;
                    case 'c':
                        resultado = cantidad;
                        Console.WriteLine("Resultado: " + resultado + " cm");
                        break;
                    case 'd':
                        resultado = cantidad / 2.54;
                        Console.WriteLine("Resultado: " + resultado + " pulg");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                break;

            case 'd':
                switch (opc2)
                {
                    case 'a':
                        resultado = cantidad / 39.3701;
                        Console.WriteLine("Resultado: " + resultado + " m");
                        break;
                    case 'b':
                        resultado = cantidad / 12;
                        Console.WriteLine("Resultado: " + resultado + " pies");
                        break;
                    case 'c':
                        resultado = cantidad * 2.54;
                        Console.WriteLine("Resultado: " + resultado + " cm");
                        break;
                    case 'd':
                        resultado = cantidad;
                        Console.WriteLine("Resultado: " + resultado + " pulg");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}