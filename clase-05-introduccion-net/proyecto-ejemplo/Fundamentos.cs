// ---- FUNDAMENTOS ----
// Variables y operadores, conversión de tipos y un ejemplo integrador.

static class Fundamentos
{
    public static void Run()
    {
        Console.WriteLine("---- VARIABLES Y OPERADORES ----");

        int edad = 20;
        const double Pi = 3.1416;
        var ciudad = "Tucumán";   // var: el tipo se infiere (string)
        Console.WriteLine($"edad={edad}, Pi={Pi}, ciudad={ciudad}");

        // Operadores
        int resto = 10 % 3;                 // 1
        bool mayor = 7 > 5;                 // true
        bool ok = (edad >= 18) && (edad < 65);
        int contador = 0; contador += 5;    // asignación compuesta
        Console.WriteLine($"resto={resto}, mayor={mayor}, ok={ok}, contador={contador}");

        Console.WriteLine("\n---- CONVERSIÓN DE TIPOS ----");

        int entero = 10;
        double d = entero;          // implícita (no se pierde info)
        double pi = 3.99;
        int truncado = (int)pi;     // explícita (cast) -> 3
        int x = Convert.ToInt32("42");
        Console.WriteLine($"double d={d}, cast (int)3.99={truncado}, Convert=\"42\"->{x}");

        bool valido = int.TryParse("abc", out int r);
        Console.WriteLine($"TryParse('abc') -> valido={valido}, r={r}");

        Console.WriteLine("\n---- EJEMPLO INTEGRADOR ----");
        // En la presentación se usa Console.ReadLine();
        // acá usamos valores fijos para que corra sin interacción.
        string nombre = "Ana";
        int anio = 2005;
        int edadCalc = DateTime.Now.Year - anio;
        if (edadCalc >= 18)
            Console.WriteLine($"Hola {nombre}, sos mayor de edad ({edadCalc}).");
        else
            Console.WriteLine($"Hola {nombre}, te faltan {18 - edadCalc} años.");

        Console.WriteLine();
    }
}
