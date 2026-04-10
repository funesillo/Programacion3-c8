namespace Programa06;

class Program2
{
    static void Main(string[] args)
    {
        const string SISTEMA = "TermoControl";
        const int TEMP_MAXIMA = 30;

        int tempActual = 25;
        bool alertaActiva = tempActual > TEMP_MAXIMA;

        Console.WriteLine("=== " + SISTEMA + " ===");
        Console.WriteLine("Temperatura actual: " + tempActual + "°C");
        Console.WriteLine("Límite permitido: " + TEMP_MAXIMA + "°C");
        Console.WriteLine("¿Hay alerta de calor?: " + alertaActiva);

        Console.ReadLine();

    }
}
