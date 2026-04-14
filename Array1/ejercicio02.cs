namespace ArrayEjercicio01
{
    class Ejerciio02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Registro Escolar --");

            int[] notas = new int[3];

            notas[0] = 10;
            notas[1] = 8;
            notas[2] = 9;

            Console.WriteLine("\nNotas del trimestre:");
            Console.WriteLine("Primer examen: " + notas[0]);
            Console.WriteLine("Segundo examen: " + notas[1]);
            Console.WriteLine("Tercer examen: " + notas[2]);

        }
    }
}