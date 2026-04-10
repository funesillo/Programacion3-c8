namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        const decimal TASA_CAMBIO = 850.25m;
        const char MONEDA_ORIGEN = '$';
        const char MONEDA_DESTINO = 'P';

        decimal dolares = 50.00m;
        decimal resultadoPesos = dolares * TASA_CAMBIO;

        Console.WriteLine("--- CONVERSOR DE DIVISAS ---");
        Console.WriteLine("Cantidad: " + MONEDA_ORIGEN + dolares);
        Console.WriteLine("Tasa del día: " + TASA_CAMBIO);
        Console.WriteLine("Total en pesos: " + MONEDA_DESTINO + resultadoPesos);

        Console.ReadLine();

    }
}
