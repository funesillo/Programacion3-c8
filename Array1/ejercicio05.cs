namespace ArrayEjercicio01
{
    class Ejerciio05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Precios del Día --");

            decimal[] precios = new decimal[3];

            precios[0] = 1500.50m;
            precios[1] = 800.00m; 
            precios[2] = 1200.00m;

            Console.WriteLine("\nCarta de precios:");
            Console.WriteLine("Opción A: $" + precios[0]);
            Console.WriteLine("Opción B: $" + precios[1]);
            Console.WriteLine("Opción C: $" + precios[2]);

        }
    }
}