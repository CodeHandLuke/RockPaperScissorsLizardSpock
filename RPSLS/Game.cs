using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
	public class Game
	{
		List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

		//member variables
		Player player1;
		Player player2;
		public string gameType;
		public int pointsToWin;

		//constructor
		public Game()
		{
			DisplayRules();
		}

		//public Setup()
		//{
		//	playerName;
		//	playerTwoName;
		//	gameType;

		//}


		//member methods
		public void DisplayRules()
		{
			Console.WriteLine("Rules\n1. Scissors cuts Paper\n2. Paper covers Rock\n3. Rock crushes Lizard\n4. Lizard poisons Spock\n5. Spock smashes Scissors\n6. Scissors decapitates Lizard\n7. Lizard eats Paper\n8. Paper disproves Spock\n9. Spock vaporizes Rock\n");
		}

		public void RunGame()
		{
			ChooseGameType();
			InitializeGame();
			
		}

		public string ChooseGameType()
		{
			bool isInputValid = false;
			while (!isInputValid)
			{
				Console.WriteLine("Do you want to proceed to Single Player? Type 'yes' to play against AI or 'no' to play against a friend!");
				gameType = Console.ReadLine();
				switch (gameType)
				{
					case "yes":
						return gameType;
					case "no":
						return gameType;
					default:
						Console.WriteLine("Invalid Input, Try again.");
						break;
				}
			}

			return gameType;
		}

		public void InitializeGame()
		{
			if (gameType == "yes")
			{
				player1 = new Human();
				player2 = new Computer();
				player1.InputName();
				RoundOne();
			}

			else if (gameType == "no")
			{
				player1 = new Human();
				player2 = new Human();
				player1.InputName();
				player2.InputName();
				RoundOne();
			}
		}

		public void RoundOne()
		{
			player1.GetGesture(gestures);
			player2.GetGesture(gestures);

		}



	}
}
