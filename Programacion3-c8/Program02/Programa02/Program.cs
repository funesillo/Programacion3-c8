namespace Programa02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Bloque 1: Año de Cursado ---");

        int año = 2026;

        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Se usa para representar fechas, años o contadores.");
        Console.WriteLine("   Valor guardado (Año actual): " + año);


        int puntaje = 21560586;
        Console.WriteLine("\n2. TIPO ENTERO (int) - Ejemplo 2:");
        Console.WriteLine("   Se usa para representar números como los de una puntuacion.");
        Console.WriteLine("   Valor guardado (Puntaje): " + puntaje);


        int telefono = 1134567890;
        Console.WriteLine("\n3. TIPO ENTERO (int) - Ejemplo 3:");
        Console.WriteLine("   Se usa para representar números de teléfono.");
        Console.WriteLine("   Valor guardado (Número de teléfono): " + telefono);

        int familia = 5;
        Console.WriteLine("\n4. TIPO ENTERO (int) - Ejemplo 4:");
        Console.WriteLine("   Se usa para representar la cantidad de integrantes de una familia.");
        Console.WriteLine("   Valor guardado (Integrantes de una Familia): " + familia);

        int cantidadDeAlumnos = 32;
        Console.WriteLine("\n5. TIPO ENTERO (int) - Ejemplo 5:");
        Console.WriteLine("   Se usa para representar la cantidad de Alumnos que tiene un docente.");
        Console.WriteLine("   Valor guardado (Cantidad de Alumnos): " + cantidadDeAlumnos);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}