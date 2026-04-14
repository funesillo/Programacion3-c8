namespace ArrayEjercicio01
{
    class Ejerciio04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Top 3 Global --");

            string[] topJugadores = new string[3];

            topJugadores[0] = "ShadowMaster";
            topJugadores[1] = "DragonBorn";
            topJugadores[2] = "PixelHero";

            Console.WriteLine("\nPodio de honor:");
            Console.WriteLine("Oro: " + topJugadores[0]);
            Console.WriteLine("Plata: " + topJugadores[1]);
            Console.WriteLine("Bronce: " + topJugadores[2]);

        }
    }
}