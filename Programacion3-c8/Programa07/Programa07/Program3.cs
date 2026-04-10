namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        const decimal TASA_INTERES = 0.05m;
        const char SIGNO = '%';

        decimal capital = 10000.00m;
        decimal ganancia = capital * TASA_INTERES;
        decimal saldoFinal = capital + ganancia;

        Console.WriteLine("--- SIMULADOR DE AHORRO ---");
        Console.WriteLine("Inversión inicial: $" + capital);
        Console.WriteLine("Rendimiento (" + (TASA_INTERES * 100) + SIGNO + "): $" + ganancia);
        Console.WriteLine("SALDO FINAL: $" + saldoFinal);

        Console.ReadLine();

    }
}
