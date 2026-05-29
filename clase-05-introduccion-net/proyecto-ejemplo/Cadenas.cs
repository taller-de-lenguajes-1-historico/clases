// ---- EL TIPO STRING ----
// string es un alias de System.String (tipo de referencia).

static class Cadenas
{
    public static void Run()
    {
        Console.WriteLine("---- CADENAS (string) ----");

        string nombre = "Ana";
        string vacio = string.Empty;

        // Concatenación e interpolación
        string concat = string.Concat("Hola, ", nombre, "!");
        string interp = $"Hola, {nombre}!";   // forma moderna (.NET 6+)
        Console.WriteLine(concat);
        Console.WriteLine(interp);

        // Acceso a caracteres (indexado a 0)
        string texto = "Ejemplo de C#";
        Console.WriteLine($"primer caracter = {texto[0]}, longitud = {texto.Length}");

        // Métodos útiles
        string reemplazado = texto.Replace("C#", "C Sharp");
        Console.WriteLine($"ToUpper        = {nombre.ToUpper()}");
        Console.WriteLine($"Substring(0,3) = {texto.Substring(0, 3)}");
        Console.WriteLine($"Replace        = {reemplazado}");
        Console.WriteLine($"IsNullOrEmpty  = {string.IsNullOrEmpty(vacio)}");

        // Conversión string -> número con TryParse
        string s = "108";
        bool ok = int.TryParse(s, out int numero);
        Console.WriteLine($"TryParse de '{s}' -> ok={ok}, numero={numero}");

        // string nullable (C# 8+)
        string? quizasNull = null;
        Console.WriteLine($"string? es null? {quizasNull is null}");

        Console.WriteLine();
    }
}
