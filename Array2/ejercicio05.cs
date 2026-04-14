namespace ArrayEjercicio02;

class Ejercicio05
{
    static void Main(string[] args)
    {
        string[] tiposPescado = { "Salmón", "Atún Rojo", "Pez Mantequilla", "Anguila" };

        Console.WriteLine("Variedades disponibles en barra:");
        foreach (string pescado in tiposPescado)
        {
            Console.WriteLine("Variedad: " + pescado);
        }
    }
}