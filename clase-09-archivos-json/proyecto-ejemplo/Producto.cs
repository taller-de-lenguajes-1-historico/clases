// Clases usadas en los ejemplos de serialización.

public class Producto
{
    public string Nombre { get; set; } = "";
    public int Precio { get; set; }
}

// Para el ejemplo de consumo de un servicio web (jsonplaceholder.typicode.com).
public class Tarea
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public bool Completed { get; set; }
}
