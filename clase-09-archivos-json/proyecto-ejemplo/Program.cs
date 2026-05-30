// Clase 9 — Archivos JSON
// Serialización/deserialización con System.Text.Json y consumo de un servicio web.
// Correr con:  dotnet run

using System.Text.Json;

Console.WriteLine("=== Clase 9 — Archivos JSON ===\n");

var opciones = new JsonSerializerOptions
{
    WriteIndented = true,            // salida prolija
    PropertyNameCaseInsensitive = true
};

// --- Serializar: objeto C# -> cadena JSON ---
Console.WriteLine("---- SERIALIZAR ----");
Producto papas = new Producto { Nombre = "Papas Fritas", Precio = 30 };
string jsonString = JsonSerializer.Serialize(papas, opciones);
Console.WriteLine(jsonString);

// --- Deserializar: cadena JSON -> objeto C# ---
Console.WriteLine("\n---- DESERIALIZAR ----");
string entrada = "{\"Nombre\":\"Empanadas\",\"Precio\":50}";
Producto? p = JsonSerializer.Deserialize<Producto>(entrada);
Console.WriteLine($"Nombre: {p?.Nombre}, Precio: {p?.Precio}");

// --- Consumir un servicio web con HttpClient (guardado por si no hay internet) ---
Console.WriteLine("\n---- SERVICIO WEB (HttpClient) ----");
try
{
    using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(6) };
    string body = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");
    Tarea? tarea = JsonSerializer.Deserialize<Tarea>(body, opciones);
    Console.WriteLine($"GET ok -> Tarea #{tarea?.Id}: \"{tarea?.Title}\" (completada: {tarea?.Completed})");
}
catch (Exception)
{
    Console.WriteLine("(sin conexión o servicio no disponible — el resto del ejemplo no lo necesita)");
}

Console.WriteLine("\n=== Fin ===");
