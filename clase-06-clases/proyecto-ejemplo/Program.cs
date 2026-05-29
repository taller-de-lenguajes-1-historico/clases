// Clase 6 — Clases (POO en C#)
// Ejecuta todos los ejemplos. Correr con:  dotnet run

Console.WriteLine("=== Clase 6 — Clases ===\n");

// --- Perro: campos, propiedades, métodos, constructor ---
Console.WriteLine("---- PERRO ----");
Perro fangio = new Perro("schnauzer");
fangio.Nombre = "Fangio";   // propiedad (set)
fangio.Edad = 3;            // propiedad (set)
Console.WriteLine($"{fangio.Nombre} ({fangio.Raza}), edad {fangio.Edad}");
Console.WriteLine($"Edad en años perro: {fangio.EdadEnAniosPerro()}");  // método

// --- Player: instancias independientes del mismo molde ---
Console.WriteLine("\n---- PLAYER ----");
Player mario = new Player();
mario.PosicionX = 20; mario.PosicionY = 10; mario.Vidas = 3;

Player luigi = new Player();
luigi.PosicionX = 30; luigi.PosicionY = 10; luigi.Vidas = 3;

mario.Saltar();   // modifica el estado de mario
Console.WriteLine($"Mario tras saltar -> X={mario.PosicionX}, Y={mario.PosicionY}");
Console.WriteLine($"Luigi sin saltar  -> X={luigi.PosicionX}, Y={luigi.PosicionY}");

// --- Clase estática: sin instancias ---
Console.WriteLine("\n---- CLASE ESTÁTICA ----");
int r = Calculadora.Sumar(2, 3);   // se usa por el nombre de la clase
Console.WriteLine($"Calculadora.Sumar(2, 3) = {r}");

Console.WriteLine("\n=== Fin ===");
