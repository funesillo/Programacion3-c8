namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        const decimal DESCUENTO_VIP = 0.15m;
        const bool ES_CLIENTE_VIP = true;

        decimal precioProducto = 2000.00m;
        decimal ahorro = ES_CLIENTE_VIP ? (precioProducto * DESCUENTO_VIP) : 0m;
        decimal precioFinal = precioProducto - ahorro;

        Console.WriteLine("--- SISTEMA DE SOCIOS ---");
        Console.WriteLine("Producto: $" + precioProducto);
        Console.WriteLine("Ahorro por ser VIP: $" + ahorro);
        Console.WriteLine("PRECIO FINAL: $" + precioFinal);

        Console.ReadLine();

    }
}
