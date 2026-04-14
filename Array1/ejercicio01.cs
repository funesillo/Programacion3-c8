namespace ArrayEjercicio01
{
    class Ejerciio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Ejercicio 1: Fundamentos de arreglos");

            string[] mochila = new string[3];

            mochila[0] = "Utiles";
            mochila[1] = "Libros";
            mochila[2] = "Carpetas";

            Console.WriteLine("Contenido:");
            Console.WriteLine("Espacio 1: " + mochila[0]);
            Console.WriteLine("Espacio 2: " + mochila[1]);
            Console.WriteLine("Espacio 3: " + mochila[2]);

        }
    }
}