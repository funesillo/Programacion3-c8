namespace ArrayEjercicio03;

class Ejercicio04
{
    static void Main(string[] args)
    {
        decimal[] gastos = { 450.50m, 320.00m, 600.75m };

        Console.WriteLine("Resumen Trimestral de Gastos:");

        for (int i = 0; i < gastos.Length; i++)
        {
            Console.WriteLine("Mes " + (i + 1) + ": $" + gastos[i]);
        }
    }
}