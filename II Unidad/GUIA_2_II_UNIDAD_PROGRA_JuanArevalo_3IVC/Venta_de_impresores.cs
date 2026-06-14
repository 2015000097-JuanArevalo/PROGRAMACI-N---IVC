internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Venta de impresores T&S, S.A de C.A ====");

        int cantidad, opcionPago;
        double precioSinIva = 650.00;
        double precioConIva = precioSinIva * 1.12;
        double totalSinDescuento, descuento = 0, totalPagar = 0;
        string formaPago = "";

        Console.Write("Ingrese la cantidad de impresoras a comprar: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad debe ser mayor que 0.");
            return;
        }

        Console.WriteLine("********************");
        Console.WriteLine("* MENÚ DE OPCIONES *");
        Console.WriteLine("********************");
        Console.WriteLine("Formas de pago:");
        Console.WriteLine("1- Efectivo");
        Console.WriteLine("2- Tarjeta de crédito");
        Console.WriteLine("3- Vale de regalo");
        Console.WriteLine("********************");

        Console.Write("Digite la opción: ");
        opcionPago = Convert.ToInt32(Console.ReadLine());

        totalSinDescuento = cantidad * precioConIva;

        switch (opcionPago)
        {
            case 1:
                formaPago = "Efectivo";
                descuento = totalSinDescuento * 0.10;
                totalPagar = totalSinDescuento - descuento;
                break;

            case 2:
                formaPago = "Tarjeta de crédito";
                descuento = totalSinDescuento * 0.05;
                totalPagar = totalSinDescuento - descuento;
                break;

            case 3:
                formaPago = "Vale de regalo";
                descuento = totalSinDescuento * 0.15;
                totalPagar = totalSinDescuento - descuento;
                break;

            default:
                Console.WriteLine("Opción no válida.");
                return;
        }
        Console.WriteLine("Cantidad de impresoras: " + cantidad);
        Console.WriteLine("Precio unitario con IVA: Q. " + precioConIva);
        Console.WriteLine("Total sin descuento: Q. " + totalSinDescuento);
        Console.WriteLine("Forma de pago: " + formaPago);
        Console.WriteLine("Descuento realizado: Q. " + descuento);
        Console.WriteLine("Total a pagar: Q. " + totalPagar);
    }
}