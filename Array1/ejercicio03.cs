namespace ArrayEjercicio01
{
    class Ejerciio03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Camara de Seguridad --");

            bool[] zonasActivas = new bool[3];

            zonasActivas[0] = true; 
            zonasActivas[1] = false;
            zonasActivas[2] = true;

            Console.WriteLine("\nMonitoreo:");
            Console.WriteLine("Zona Norte activa: " + zonasActivas[0]);
            Console.WriteLine("Zona Centro activa: " + zonasActivas[1]);
            Console.WriteLine("Zona Sur activa: " + zonasActivas[2]);

        }
    }
}