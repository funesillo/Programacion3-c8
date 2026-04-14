namespace ArrayEjercicio02;

class Ejercicio04
{
    static void Main(string[] args)
    {
        decimal[] totalesVenta = { 1500.25m, 890.00m, 2100.50m, 450.75m };

        Console.WriteLine("Resumen de ventas del turno:");
        foreach (decimal monto in totalesVenta)
        {
            Console.WriteLine("Monto procesado: $" + monto);
        }
    }
}