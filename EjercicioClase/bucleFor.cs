namespace EjercicioClase;

class BucleFor
{
    static void Main(string[] args)
    {
        string[] nombres = new string[20];
        int[] edades = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Ingrese su nombre " + (i + 1) + " :");
            nombres[i] = Console.ReadLine();

            Console.WriteLine("Indique su edad para ingresar al establecimiento " + (i + 1) + " :");
            edades[i] = int.Parse(Console.ReadLine());

            if (edades[i] >= 30)
            {
                Console.WriteLine(nombres[i] + " es mayor de edad.");
            }
            else
            {
                Console.WriteLine(nombres[i] + " A la casa");
            }
        }
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Tu nombre es :" + nombres[i]);
            Console.WriteLine("Tu edad es :" + edades[i]);
        }
    }
}