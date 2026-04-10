namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        const decimal PORCENTAJE_PROPINA = 0.10m; 
        const char ICONO = '★';

        decimal consumoComida = 4500.50m;
        decimal propinaSugerida = consumoComida * PORCENTAJE_PROPINA;
        decimal totalConPropina = consumoComida + propinaSugerida;

        Console.WriteLine("--- TICKET DE SERVICIO " + ICONO + " ---");
        Console.WriteLine("Consumo: $" + consumoComida);
        Console.WriteLine("Propina sugerida: $" + propinaSugerida);
        Console.WriteLine("TOTAL A PAGAR: $" + totalConPropina);

        Console.ReadLine();

    }
}
