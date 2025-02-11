using System;

public class Tablero
{
    private int ancho;
    private int alto;
    public int Ancho { get => ancho; set => ancho = value; }
    public int Alto { get => alto; set => alto = value; }

    public Tablero(int ancho, int alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public void PintarTablero()
    {
        for (int i = 0; i <= Alto; i++)
        {
            Utils.PintarEnPosicion(Ancho, i, "#");
            Utils.PintarEnPosicion(0, i, "#");
        }

        for (int i = 0; i <= Ancho; i++)
        {
            Utils.PintarEnPosicion(i, 0, "#");
            Utils.PintarEnPosicion(i, Alto, "#");
        }
    }

}
