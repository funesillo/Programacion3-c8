namespace ArrayEjercicio02;

class Ejercicio03
{
    static void Main(string[] args)
    {
        int[] estadosRespuesta = { 200, 404, 500, 201 };

        Console.WriteLine("Historial de respuestas del servidor:");
        foreach (int codigo in estadosRespuesta)
        {
            Console.WriteLine("Código detectado: " + codigo);
        }
    }
}