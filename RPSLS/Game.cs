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
				Console.WriteLine("Do you want to proceed to Single Player? Type 'yes' to play against AI or 'no' to play against another person!");
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
				ScoreCheck();
			}

			else if (gameType == "no")
			{
				player1 = new Human();
				player2 = new Human();
				player1.InputName();
				player2.InputName();
				ScoreCheck();
			}
		}

		public void ScoreCheck()
		{
			pointsToWin = 2;
			if (player1.score >= pointsToWin)
			{
				Console.WriteLine($"{player1.playerName} has won the best of three game!");
				//restart or end game method
				Console.ReadLine();
			}

			else if (player2.score >= pointsToWin)
			{
				Console.WriteLine($"{player2.playerName} has won the best of three game!");
				//restart or end game method
				Console.ReadLine();
			}

			else
			{
				PlayGame();
			}
		}

		public void PlayGame() //possibly change name to game loop
		{
			//create a while or a do-while loop for to run this as long as the players' scores are less than 2
			player1.GetGesture(gestures);
			DisplayRules();
			player2.GetGesture(gestures);
			Console.WriteLine($"{player1.playerName} chose {player1.selectedGesture} and {player2.playerName} chose {player2.selectedGesture}! Press enter to tally score");
			Console.ReadLine();
			CompareGestures();
			ShowMatchTally();
		}

		public void CompareGestures()
		{
			if (player1.selectedGesture == "rock" && player2.selectedGesture == "scissors")
			{
				player1.score += 1;
			}
		}

		public void ShowMatchTally()
		{
			Console.WriteLine($"The current tally is {player1.playerName}: {player1.score} vs {player2.playerName}: {player2.score}. Press Enter to go to next phase.");
			Console.ReadLine();
			Console.Clear();
			ScoreCheck();
		}



	}
}
