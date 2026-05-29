// ---- Streams (System.IO) ----
// StreamWriter/StreamReader (texto) y FileStream (bytes).

using System.IO;
using System.Text;

static class Flujos
{
    public static void Run(string carpeta)
    {
        Console.WriteLine("---- STREAMS ----");

        string ruta = Path.Combine(carpeta, "saludo.txt");

        // Escribir con StreamWriter (texto)
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Hola desde un StreamWriter");
            sw.WriteLine("Segunda línea");
        } // el using cierra y libera el archivo

        // Leer con StreamReader (texto, línea por línea)
        Console.WriteLine("Leído con StreamReader:");
        using (StreamReader sr = new StreamReader(ruta))
        {
            string? linea;
            while ((linea = sr.ReadLine()) != null)
                Console.WriteLine($"  {linea}");
        }

        // Leer bytes con FileStream y convertir a texto
        using (FileStream fs = new FileStream(ruta, FileMode.Open))
        {
            byte[] buffer = new byte[16];
            int leidos = fs.Read(buffer, 0, buffer.Length);
            string texto = Encoding.UTF8.GetString(buffer, 0, leidos);
            Console.WriteLine($"FileStream: leídos {leidos} bytes -> \"{texto}\"");
            Console.WriteLine($"  CanRead={fs.CanRead}, CanSeek={fs.CanSeek}, Length={fs.Length}");
        }

        Console.WriteLine();
    }
}
