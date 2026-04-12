internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Identificador de Caracteres ====");

        Console.Write("Ingrese un carácter: ");
        char c = Convert.ToChar(Console.ReadLine().ToLower());

        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Es una vocal.");
                break;

            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Es un dígito.");
                break;

            default:
                Console.WriteLine("No es vocal ni dígito.");
                break;
        }
    }
}