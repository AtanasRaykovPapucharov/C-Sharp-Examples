using System;

public class StoneKnifePaper
{
	public static void Main()
	{
		string stoneWin = "Stone breaks knife.";
		string knifeWin = "Knife cuts paper.";
		string paperWin = "Paper coverss stone.";

		Console.WriteLine("Stone, knife, paper");
		Console.WriteLine("------------------------------------");
		Console.WriteLine("stone is 0 | knife is 1 | paper is 2");
		Console.WriteLine("------------------------------------");
		Console.WriteLine("Enter 0, 1 or 2 : ");
		Console.WriteLine("------------------------------------");

		string[] gameElements = new string[] { "stone", "knife", "paper" };

		int userChoice = int.Parse(Console.ReadLine());

		Random random = new Random();

		int computerChoice = random.Next(0, 3);

		Console.WriteLine("You choose a " + gameElements[userChoice]);
		Console.WriteLine("------------------------------------");
		Console.WriteLine("Computer choose a " + gameElements[computerChoice]);
		Console.WriteLine("------------------------------------");

		switch (computerChoice)
		{
			case 0:
				if (userChoice == 1)
				{
					Console.WriteLine(stoneWin + " Computer wins!");
				}
				else if (userChoice == 2)
				{
					Console.WriteLine(paperWin + " You win!");
				}
				else
				{
					Console.WriteLine("No one win!");
				}
				break;
			case 1:
				if (userChoice == 2)
				{
					Console.WriteLine(knifeWin + " Computer wins!");
				}
				else if (userChoice == 0)
				{
					Console.WriteLine(stoneWin + " You win!");
				}
				else
				{
					Console.WriteLine("No one win!");
				}
				break;
			case 2:
				if (userChoice == 0)
				{
					Console.WriteLine(paperWin + " Computer wins!");
				}
				else if (userChoice == 1)
				{
					Console.WriteLine(knifeWin + " You win!");
				}
				else
				{
					Console.WriteLine("No one win!");
				}
				break;
			default:
				break;
		}
	}
}