// ---- Directory y File (System.IO) ----
// Métodos estáticos para crear/consultar directorios y archivos.

using System.IO;

static class Archivos
{
    public static void Run(string carpeta)
    {
        Console.WriteLine("---- DIRECTORY / FILE ----");

        // Crear el directorio si no existe
        if (!Directory.Exists(carpeta))
        {
            Directory.CreateDirectory(carpeta);
            Console.WriteLine($"Directorio creado: {carpeta}");
        }

        string ruta = Path.Combine(carpeta, "personas.csv");

        // Escribir texto (crea o reemplaza el archivo)
        string[] lineas = { "nombre,apellido,edad", "Ana,Pérez,20", "Luis,Gómez,22" };
        File.WriteAllLines(ruta, lineas);
        Console.WriteLine($"Archivo escrito: {ruta}");

        // Existe?
        Console.WriteLine($"File.Exists -> {File.Exists(ruta)}");

        // Leer todo el contenido
        string[] leidas = File.ReadAllLines(ruta);
        Console.WriteLine($"Líneas leídas: {leidas.Length}");
        foreach (string l in leidas) Console.WriteLine($"  {l}");

        // Listar archivos del directorio
        string[] archivos = Directory.GetFiles(carpeta);
        Console.WriteLine($"Archivos en el directorio: {archivos.Length}");

        Console.WriteLine();
    }
}
