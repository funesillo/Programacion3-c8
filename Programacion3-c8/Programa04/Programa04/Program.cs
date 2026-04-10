namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

        string materia = "Programación I";
        Console.WriteLine("1. TIPO CADENA DE TEXTO (string):");
        Console.WriteLine("   Se usa para palabras, frases o párrafos completos.");
        Console.WriteLine("   Materia actual: " + materia);

        char categoria = 'G';
        Console.WriteLine("\n2. TIPO CARÁCTER ÚNICO (char):");
        Console.WriteLine("   ¡Ojo! Solo guarda UN símbolo, letra o número.");
        Console.WriteLine("   Categoria Actual: '" + categoria);

        string descripcionProducto = "Vino importado de las regiones andinas fermentado en barricas de roble";
        Console.WriteLine("\n3. TIPO CADENA DE TEXTO (string) - Ejemplo 3:");
        Console.WriteLine("   Se usa para describir productos, como en un catálogo.");
        Console.WriteLine("   Descripción del producto: " + descripcionProducto);

        char inicialNombre = 'F';
        Console.WriteLine("\n4. TIPO CARÁCTER ÚNICO (char) - Ejemplo 4:");
        Console.WriteLine("   Se usa para representar la inicial de un nombre.");
        Console.WriteLine("   Inicial del nombre: '" + inicialNombre + "'");

        char genero = 'M';
        Console.WriteLine("\n5. TIPO CARÁCTER ÚNICO (char) - Ejemplo 5:");
        Console.WriteLine("   Se usa para representar el género de una persona.");
        Console.WriteLine("   Género: '" + genero + "' (F de Femenino)");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

    }
}
