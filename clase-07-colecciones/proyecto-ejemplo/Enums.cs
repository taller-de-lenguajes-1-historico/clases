// ---- ENUM ----
// Tipo valor: una lista de constantes con nombre.

static class Enums
{
    public static void Run()
    {
        Console.WriteLine("---- ENUM ----");

        DiaDeLaSemana hoy = DiaDeLaSemana.Domingo;
        Console.WriteLine($"hoy = {hoy} (valor {(int)hoy})");

        // enum con tipo subyacente explícito
        ErrorCode err = ErrorCode.PerdidaDeConexion;
        Console.WriteLine($"error = {err} (código {(ushort)err})");

        // --- Enum con [Flags]: combinación de opciones ---
        Dias finde = Dias.Domingo | Dias.Sabado;   // OR para combinar
        Console.WriteLine($"finde = {finde}");
        Console.WriteLine($"¿incluye Sábado? {finde.HasFlag(Dias.Sabado)}");  // AND interno

        Console.WriteLine();
    }
}

enum DiaDeLaSemana
{
    Domingo = 0, Lunes = 1, Martes = 2, Miercoles = 3,
    Jueves = 4, Viernes = 5, Sabado = 6
}

enum ErrorCode : ushort
{
    Ninguno = 0,
    PerdidaDeConexion = 100,
    RecursoNoEncontrado = 404
}

[Flags]
enum Dias
{
    Ninguno = 0,
    Domingo = 1, Lunes = 2, Martes = 4, Miercoles = 8,
    Jueves = 16, Viernes = 32, Sabado = 64
}
