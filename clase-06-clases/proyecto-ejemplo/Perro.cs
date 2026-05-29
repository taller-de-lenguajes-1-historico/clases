// Clase con campos privados, propiedades, un método y un constructor.

public class Perro
{
    // Campos privados (estado interno, no accesible desde afuera)
    private string nombre = "";
    private string raza;
    private int edad;

    // Constructor: mismo nombre que la clase, sin tipo de retorno
    public Perro(string raza)
    {
        this.raza = raza;
    }

    // Propiedades: exponen los campos privados de forma controlada
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public string Raza => raza;   // solo lectura

    public int Edad
    {
        get => edad;
        set => edad = value;
    }

    // Método: comportamiento que opera sobre los datos del objeto
    public int EdadEnAniosPerro()
    {
        return edad * 7;
    }
}
