using System;

public class Juego
{
	static void Main(string[] args)
	{
		Console.WriteLine("¿De cuánto será el tablero?");
		int dimensiones = Convert.ToInt32(Console.ReadLine());
		Tablero tablero = new Tablero(dimensiones, dimensiones);
		tablero.PintarTablero();
	}

	public Juego()
	{
	}
}
