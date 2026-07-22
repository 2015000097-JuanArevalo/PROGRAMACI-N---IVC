using System;

class Program
{
    static string DecimalABinario(int numero)
    {
        if (numero == 0)
            return "0";

        string binario = "";

        while (numero > 0)
        {
            int residuo = numero % 2;
            binario = residuo + binario;
            numero = numero / 2;
        }

        return binario;
    }

    static int BinarioADecimal(string binario, out bool valido)
    {
        int resultado = 0;
        valido = true;

        for (int i = 0; i < binario.Length; i++)
        {
            if (binario[i] != '0' && binario[i] != '1')
            {
                valido = false;
                return 0;
            }

            resultado = resultado * 2 + (binario[i] - '0');
        }

        return resultado;
    }

    static void Main()
    {
        Console.WriteLine("Nombre: Juan Arevalo");
        Console.WriteLine("Grado: IVC - Clave: 3");
        Console.WriteLine("===Conversion Decimal y Binario===");

        Console.WriteLine("1. Decimal a binario");
        Console.WriteLine("2. Binario a decimal");
        Console.Write("Seleccione una opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese un numero decimal entero positivo: ");
                int numeroDecimal = Convert.ToInt32(Console.ReadLine());

                if (numeroDecimal < 0)
                    Console.WriteLine("El numero debe ser positivo.");
                else
                    Console.WriteLine("Resultado binario: " + DecimalABinario(numeroDecimal));
                break;

            case 2:
                Console.Write("Ingrese un numero binario: ");
                string numeroBinario = Console.ReadLine();

                bool valido;
                int resultado = BinarioADecimal(numeroBinario, out valido);

                if (valido)
                    Console.WriteLine("Resultado decimal: " + resultado);
                else
                    Console.WriteLine("El numero binario es invalido.");
                break;

            default:
                Console.WriteLine("Opcion invalida.");
                break;
        }
    }
}
