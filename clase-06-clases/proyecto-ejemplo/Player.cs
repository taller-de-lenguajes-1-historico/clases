// La clase Player es el "molde": define datos y comportamiento.
// Mario y Luigi son objetos concretos (instancias) creados con new.

public class Player
{
    // Datos (estado)
    public float PosicionY;          // altura actual
    public float VelocidadY;         // velocidad vertical
    public bool EnElSuelo = true;
    public int Vidas = 3;

    private const float Gravedad = 9.8f;
    private const float Impulso = 20f;

    // Da el impulso inicial hacia arriba (solo si está apoyado)
    public void Saltar()
    {
        if (EnElSuelo)
        {
            VelocidadY = Impulso;
            EnElSuelo = false;
        }
    }

    // Avanza un cuadro (frame) de simulación: la gravedad frena el ascenso
    // y luego lo hace caer -> la trayectoria resultante es una parábola.
    public void Actualizar(float dt)
    {
        VelocidadY -= Gravedad * dt;
        PosicionY += VelocidadY * dt;

        if (PosicionY <= 0)          // tocó el suelo
        {
            PosicionY = 0;
            VelocidadY = 0;
            EnElSuelo = true;
        }
    }
}
