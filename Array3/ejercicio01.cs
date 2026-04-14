namespace ArrayEjercicio03;

class Ejercicio01
{
    static void Main(string[] args)
    {
        string[] versiones = { "1.0.1", "1.1.0", "2.0.0-beta", "2.1.5" };

        Console.WriteLine("Historial de despliegues:");

        for (int i = 0; i < versiones.Length; i++)
        {
            Console.WriteLine("Build #" + (i + 1) + ": v" + versiones[i]);
        }
    }
}