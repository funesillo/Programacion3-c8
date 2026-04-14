namespace ArrayEjercicio03;

class Ejercicio03
{
    static void Main(string[] args)
    {
        double[] medidasGramos = { 500.0, 15.5, 100.75, 25.0 };

        Console.WriteLine("Cantidades para la preparación:");

        for (int i = 0; i < medidasGramos.Length; i++)
        {
            Console.WriteLine("Ingrediente " + (i + 1) + ": " + medidasGramos[i] + "g");
        }
    }
}