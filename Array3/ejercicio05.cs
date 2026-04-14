namespace ArrayEjercicio03;

class Ejercicio05
{
    static void Main(string[] args)
    {
        float[] voltajes = { 5.0f, 4.8f, 12.2f, 3.3f };

        Console.WriteLine("Estado de la placa base:");

        for (int i = 0; i < voltajes.Length; i++)
        {
            Console.WriteLine("Pin [" + i + "] -> Voltaje: " + voltajes[i] + "V");
        }
    }
}