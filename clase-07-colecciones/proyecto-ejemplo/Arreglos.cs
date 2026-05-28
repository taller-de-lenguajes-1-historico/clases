// ---- ARREGLOS ----
// Grupo de variables del mismo tipo, tamaño fijo, indexado a cero.

static class Arreglos
{
    public static void Run()
    {
        Console.WriteLine("---- ARREGLOS ----");

        // Declaración e inicialización (reference type -> new)
        int[] intArray1 = new int[5];          // se inicializa todo en 0
        int[,] b = new int[7, 8];              // arreglo bidimensional
        string[] autos = { "Volvo", "BMW", "Ford", "Mazda" };

        Console.WriteLine($"autos.Length            = {autos.Length}");
        Console.WriteLine($"autos[0]                = {autos[0]}");
        Console.WriteLine($"intArray1[0] (default)  = {intArray1[0]}");
        Console.WriteLine($"matriz b                = {b.GetLength(0)} x {b.GetLength(1)}");

        // Recorrer (índice base 0: de 0 a n-1)
        Console.WriteLine("Recorriendo autos:");
        for (int i = 0; i < autos.Length; i++)
            Console.WriteLine($"  [{i}] {autos[i]}");

        Console.WriteLine();
    }
}
