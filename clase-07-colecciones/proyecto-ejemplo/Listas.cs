// ---- LISTAS (List<T>) ----
// La colección genérica más usada: tamaño dinámico, acceso por índice.

static class Listas
{
    public static void Run()
    {
        Console.WriteLine("---- LISTAS ----");

        // --- Crear y agregar ---
        List<string> frutas = new List<string>();
        frutas.Add("Manzana");
        frutas.Add("Banana");
        frutas.Add("Naranja");

        // inicializar con valores
        List<int> numeros = new List<int>() { 10, 20, 30 };

        // --- Acceder, recorrer y contar ---
        Console.WriteLine($"primera = {frutas[0]}");   // base 0
        Console.WriteLine($"total   = {frutas.Count}");

        // --- Más operaciones ---
        Console.WriteLine($"Contains(\"Banana\") = {frutas.Contains("Banana")}");
        Console.WriteLine($"IndexOf(\"Naranja\") = {frutas.IndexOf("Naranja")}");
        frutas.Insert(1, "Pera");        // insertar en posición
        frutas.Remove("Manzana");        // quitar por valor

        numeros.AddRange(new int[] { 40, 50 });
        numeros.Sort();                  // 10, 20, 30, 40, 50
        numeros.Reverse();               // 50, 40, 30, 20, 10
        Console.WriteLine("numeros = " + string.Join(", ", numeros));

        // --- Formas de recorrer (iteradores) ---
        Console.WriteLine("for con índice:");
        for (int i = 0; i < frutas.Count; i++)
            Console.WriteLine($"  [{i}] {frutas[i]}");

        Console.WriteLine("foreach:");
        foreach (string f in frutas)
            Console.WriteLine($"  {f}");

        Console.WriteLine("enumerador manual (lo que hace foreach por dentro):");
        IEnumerator<string> e = frutas.GetEnumerator();
        while (e.MoveNext())
            Console.WriteLine($"  {e.Current}");

        // --- Listas de objetos ---
        List<Persona> estudiantes = new List<Persona>();
        estudiantes.Add(new Persona { Nombre = "Ana", Edad = 20 });
        estudiantes.Add(new Persona { Nombre = "Luis", Edad = 22 });

        Console.WriteLine("estudiantes:");
        foreach (Persona p in estudiantes)
            Console.WriteLine($"  {p.Nombre} - {p.Edad}");

        // filtrar manualmente (sin LINQ)
        List<Persona> mayoresManual = new List<Persona>();
        foreach (Persona p in estudiantes)
            if (p.Edad > 21) mayoresManual.Add(p);
        Console.WriteLine($"mayores de 21 (manual) = {mayoresManual.Count}");

        // --- Lo mismo con LINQ (declarativo) ---
        List<Persona> mayores = estudiantes.Where(p => p.Edad > 21).ToList();
        List<string> nombres = estudiantes.Select(p => p.Nombre).ToList();
        bool hayMayor = estudiantes.Any(p => p.Edad >= 18);
        double promedio = estudiantes.Average(p => p.Edad);

        Console.WriteLine($"LINQ -> mayores={mayores.Count}, " +
                          $"nombres=[{string.Join(", ", nombres)}], " +
                          $"hayMayor={hayMayor}, promedioEdad={promedio}");

        Console.WriteLine();
    }
}

class Persona
{
    public string Nombre = "";
    public int Edad;
}
