// ---- TIPOS DE DATOS ----
// Tipos de valor vs tipos de referencia, struct, nullable y DateTime.

static class Tipos
{
    public static void Run()
    {
        Console.WriteLine("---- TIPOS ----");

        // Tipos simples (valor)
        int entero = 42;
        double real = 3.14;
        bool verdadero = true;
        char letra = 'C';
        Console.WriteLine($"int={entero}, double={real}, bool={verdadero}, char={letra}");

        // var: el compilador infiere el tipo (sigue siendo fuertemente tipado)
        var inferido = 100;          // int
        Console.WriteLine($"var inferido es {inferido.GetType().Name} = {inferido}");

        // Valor vs referencia: el valor se COPIA
        int a = 5;
        int b = a;     // copia independiente
        b = 99;
        Console.WriteLine($"valor -> a={a}, b={b} (a no cambió)");

        // struct: tipo de valor que agrupa variables relacionadas
        Coords p = new Coords(10, 20);
        Console.WriteLine($"struct Coords -> x={p.x}, y={p.y}");

        // Nullable: permitir null en tipos de valor
        int? edad = null;
        Console.WriteLine($"nullable edad tiene valor? {edad.HasValue}");

        // DateTime
        DateTime hoy = DateTime.Now;
        DateTime fecha = new DateTime(2023, 5, 15, 8, 30, 0);
        Console.WriteLine($"hoy={hoy:yyyy-MM-dd}, fecha fija={fecha:yyyy-MM-dd HH:mm}");

        Console.WriteLine();
    }
}

// struct = tipo de valor para agrupar variables relacionadas
public struct Coords
{
    public int x, y;

    public Coords(int p1, int p2)
    {
        x = p1;
        y = p2;
    }
}
