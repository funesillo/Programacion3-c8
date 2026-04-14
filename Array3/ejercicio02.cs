namespace ArrayEjercicio03;

class Ejercicio02
{
    static void Main(string[] args)
    {
        int[] existencias = { 15, 8, 24, 0, 12 };

        Console.WriteLine("Reporte de Stock:");

        for (int i = 0; i < existencias.Length; i++)
        {
            Console.WriteLine("Pasillo " + i + " - Unidades: " + existencias[i]);
        }
    }
}