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

// --- Player: dos objetos concretos del mismo molde ---
Console.WriteLine("\n---- PLAYER ----");
Player mario = new Player();   // objeto concreto
Player luigi = new Player();   // otro objeto, estado independiente
mario.Vidas = 5;

// El salto: impulso + gravedad cuadro a cuadro => parábola
mario.Saltar();
Console.WriteLine("Salto de Mario (altura por cuadro):");
for (int frame = 0; frame < 8; frame++)
{
    mario.Actualizar(0.5f);   // dt = 0.5 s por cuadro
    int barra = (int)(mario.PosicionY);
    Console.WriteLine($"  t={frame * 0.5f:0.0}s  altura={mario.PosicionY,5:0.0}  {new string('█', Math.Max(0, barra))}");
}
Console.WriteLine($"Luigi no saltó -> altura={luigi.PosicionY}, enElSuelo={luigi.EnElSuelo}, vidas={luigi.Vidas}");
Console.WriteLine($"(Mario tiene {mario.Vidas} vidas; cambiarlas no afectó a Luigi)");

// --- Clase estática: sin instancias ---
Console.WriteLine("\n---- CLASE ESTÁTICA ----");
int r = Calculadora.Sumar(2, 3);   // se usa por el nombre de la clase
Console.WriteLine($"Calculadora.Sumar(2, 3) = {r}");

Console.WriteLine("\n=== Fin ===");
