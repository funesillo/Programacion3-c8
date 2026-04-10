namespace Programa06;

class Program3
{
    static void Main(string[] args)
    {
        const string ZONA = "Cueva del Dragón";
        const int NIVEL_REQUERIDO = 10;

        int nivelJugador = 12;
        bool accesoConcedido = nivelJugador >= NIVEL_REQUERIDO;

        Console.WriteLine("--- Exploración: " + ZONA + " ---");
        Console.WriteLine("Nivel del héroe: " + nivelJugador);
        Console.WriteLine("¿Puede entrar?: " + accesoConcedido);
        Console.ReadLine();

    }
}
