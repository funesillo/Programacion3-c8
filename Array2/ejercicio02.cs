namespace ArrayEjercicio02;

class Ejercicio02
{
    static void Main(string[] args)
    {
        string[] modulos = { "Login", "Dashboard", "Ajustes", "Reportes" };

        Console.WriteLine("Cargando módulos del sistema:");
        foreach (string modulo in modulos)
        {
            Console.WriteLine("Iniciando: " + modulo + ".js");
        }
    }
}