// Clase 8 — Manejo de archivos
// Ejemplos con System.IO. Correr con:  dotnet run
// Usa una carpeta temporal para que funcione en cualquier sistema.

using System.IO;

Console.WriteLine("=== Clase 8 — Manejo de archivos ===\n");

string carpeta = Path.Combine(Path.GetTempPath(), "clase8-demo");

Archivos.Run(carpeta);
Flujos.Run(carpeta);

Console.WriteLine("\n=== Fin ===");
