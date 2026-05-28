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

        // --- Ejemplo práctico: una pila genérica reutilizable ---
        Pila<string> tareas = new Pila<string>();
        tareas.Apilar("Estudiar");
        tareas.Apilar("Practicar");
        Console.WriteLine($"Pila<string>.Desapilar() = {tareas.Desapilar()}");  // "Practicar"
        Console.WriteLine($"Pila<string>.Cantidad    = {tareas.Cantidad}");      // 1

        // la MISMA clase, ahora con int
        Pila<int> numeros = new Pila<int>();
        numeros.Apilar(10);
        numeros.Apilar(20);
        Console.WriteLine($"Pila<int>.Desapilar()    = {numeros.Desapilar()}");  // 20

        Console.WriteLine();
    }
}

// Pila genérica: una sola clase que sirve para cualquier tipo T
public class Pila<T>
{
    private List<T> items = new List<T>();

    public void Apilar(T item) => items.Add(item);

    public T Desapilar()
    {
        T ultimo = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return ultimo;
    }

    public int Cantidad => items.Count;
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
