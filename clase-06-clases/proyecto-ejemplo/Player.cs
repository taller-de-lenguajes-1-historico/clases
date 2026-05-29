// La clase Player es el "molde": define datos y comportamiento.
// Mario y Luigi son instancias independientes creadas con new.

public class Player
{
    // Datos (estado)
    public float PosicionX;
    public float PosicionY;
    public int Vidas;

    // Comportamiento
    public void Saltar()
    {
        PosicionX += 5;
        PosicionY += 10;
    }
}
