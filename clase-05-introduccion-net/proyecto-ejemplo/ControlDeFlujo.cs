// ---- ESTRUCTURAS DE CONTROL DE FLUJO ----
// Decisión (if/else, switch) y ciclos (for, while, do-while, foreach).

static class ControlDeFlujo
{
    public static void Run()
    {
        Console.WriteLine("---- CONTROL DE FLUJO ----");

        // if / else
        int nota = 7;
        if (nota >= 6) Console.WriteLine("Aprobado");
        else Console.WriteLine("Desaprobado");

        // switch
        int dia = 3;
        string nombreDia = dia switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miércoles",
            _ => "Otro"
        };
        Console.WriteLine($"switch: dia {dia} = {nombreDia}");

        // for
        Console.Write("for:    ");
        for (int i = 1; i <= 5; i++) Console.Write(i + " ");
        Console.WriteLine();

        // while
        Console.Write("while:  ");
        int n = 5;
        while (n > 0) { Console.Write(n + " "); n--; }
        Console.WriteLine();

        // do-while (se ejecuta al menos una vez)
        Console.Write("do:     ");
        int k = 0;
        do { Console.Write(k + " "); k++; } while (k < 3);
        Console.WriteLine();

        // foreach (recorrer una colección)
        Console.Write("foreach:");
        string[] lenguajes = { "C#", "F#", "VB.NET" };
        foreach (string lng in lenguajes) Console.Write(" " + lng);
        Console.WriteLine();

        Console.WriteLine();
    }
}
