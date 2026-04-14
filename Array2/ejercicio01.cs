namespace ArrayEjercicio02;

class Ejercicio01
{
    static void Main(string[] args)
    {
        string[] ingredientes = { "Arroz", "Salmón", "Nori", "Vinagre de arroz", "Wasabi" };

        Console.WriteLine("Ingredientes para el Sushi:");
        foreach (string item in ingredientes)
        {
            Console.WriteLine("• " + item);
        }
    }
}