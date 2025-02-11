using System;

public class Utils
{
    public static void PintarEnPosicion(int x, int y, string c)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(c);
    }
}
