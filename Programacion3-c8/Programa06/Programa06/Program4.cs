namespace Programa06;

class Program4
{
    static void Main(string[] args)
    {
        const string TIENDA = "TechStore";
        const int MINIMO_COMPRA = 5000;

        int totalCompra = 6500;
        bool aplicaEnvioGratis = totalCompra >= MINIMO_COMPRA;

        Console.WriteLine("Bienvenido a " + TIENDA);
        Console.WriteLine("Total de su orden: $" + totalCompra);
        Console.WriteLine("¿Obtiene envío gratis?: " + aplicaEnvioGratis);
        Console.ReadLine();

    }
}
