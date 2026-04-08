namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

        // Cadena de texto (string) - Comillas dobles ""
        string producto = "Coca-Cola";
        Console.WriteLine("4. TIPO CADENA DE TEXTO (string):");
        Console.WriteLine("   Se usa para palabras, frases o párrafos completos.");
        Console.WriteLine("   Producto actual: " + producto);

        // Carácter único (char) - Comillas simples ''
        char nivel = 'F';
        Console.WriteLine("\n5. TIPO CARÁCTER ÚNICO (char):");
        Console.WriteLine("   ¡Ojo! Solo guarda UN símbolo, letra o número.");
        Console.WriteLine("   Nivel de dificultad: '" + nivel + "' (F de Familiar)");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

    }
}
