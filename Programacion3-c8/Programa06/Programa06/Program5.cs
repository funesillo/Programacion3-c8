namespace Programa06;

class Program5
{
    static void Main(string[] args)
    {
        const string MODO = "Administrador";
        const string TOKEN_VALIDO = "ABC123";

        string tokenIngresado = "ABC123";
        bool esSesionValida = tokenIngresado == TOKEN_VALIDO;

        Console.WriteLine("Iniciando sistema en modo: " + MODO);
        Console.WriteLine("Validando credenciales...");
        Console.WriteLine("¿Acceso correcto?: " + esSesionValida);

        Console.ReadLine();

    }
}
