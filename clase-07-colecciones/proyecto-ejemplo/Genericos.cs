// ---- GENÉRICOS ----
// Un contenedor para un tipo de dato que se define al instanciar.

static class Genericos
{
    public static void Run()
    {
        Console.WriteLine("---- GENÉRICOS ----");

        // El parámetro T se sustituye por el tipo concreto al instanciar
        MiClase<int> entero = new MiClase<int>(42);
        MiClase<string> texto = new MiClase<string>("Hola");

        Console.WriteLine($"MiClase<int>.GetValor()    = {entero.GetValor()}");
        Console.WriteLine($"MiClase<string>.GetValor() = {texto.GetValor()}");

        Console.WriteLine();
    }
}

// Declaración e implementación de un tipo genérico
public class MiClase<T>
{
    private T value;

    public MiClase(T t)
    {
        value = t;
    }

    public T GetValor()
    {
        return value;
    }
}
