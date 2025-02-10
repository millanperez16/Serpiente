using System;

public class Manzana
{
	private int x;
	private int y;
    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }

    public Manzana()
	{
	}

    public Manzana(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void PintarManzana()
    {

    }
}
