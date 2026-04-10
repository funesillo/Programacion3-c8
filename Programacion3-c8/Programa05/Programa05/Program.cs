namespace Programa05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 4: VALORES LÓGICOS (SÍ / NO) ---");

        bool cursoCompletado = true;

        Console.WriteLine("1. TIPO LÓGICO (bool):");
        Console.WriteLine("   Solo puede ser 'true' o 'false'.");
        Console.WriteLine("   ¿El curso está completado?: " + cursoCompletado);

        bool asistencia = false;
        Console.WriteLine("\n2. TIPO LÓGICO (bool) - Ejemplo 2:");
        Console.WriteLine("   Se usa para representar la asistencia de un empleado.");
        Console.WriteLine("   ¿El empleado se encuentra presente?: " + asistencia);

        bool proyectoEntregado = true;
        Console.WriteLine("\n3. TIPO LÓGICO (bool) - Ejemplo 3:");
        Console.WriteLine("   Se usa para indicar si un proyecto fue entregado a tiempo.");
        Console.WriteLine("   ¿El proyecto fue entregado a tiempo?: " + proyectoEntregado);

        bool productoEntrega = false;
        Console.WriteLine("\n4. TIPO LÓGICO (bool) - Ejemplo 4:");
        Console.WriteLine("   Se usa para indicar si un producto fue entregado.");
        Console.WriteLine("   ¿El producto fue despachado?: " + productoEntrega);

        bool contraseñaCorrecta = true;
        Console.WriteLine("\n5. TIPO LÓGICO (bool) - Ejemplo 5:");
        Console.WriteLine("   Se usa para verificar si una contraseña es correcta.");
        Console.WriteLine("   ¿La contraseña ingresada es correcta?: " + contraseñaCorrecta);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
