internal class Program
{
    private static void Main(string[] args)
    {
        string password;

        Console.Write("Ingrese su contraseña: ");
        password = Console.ReadLine();

        if (password == "Password123")
            Console.WriteLine("Bienvenido");
        else
            Console.WriteLine("Acceso denegado");
    }
}