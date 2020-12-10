using System;

class Exercise
{
	static void Main()
	{
		SportBall volley = new SportBall(6, SportCategory.Collective, "Volley Ball");
		volley.Length = 18;
		volley.Width = 9;
		volley.SportCharacteristics();

		Console.WriteLine();

		SportBall tennis = new SportBall(1, SportCategory.SinglePlayer, "Table Tennis");
		tennis.Length = 23.7;
		tennis.Width = 8.25;
		tennis.SportCharacteristics();

		Console.WriteLine();
	}
}