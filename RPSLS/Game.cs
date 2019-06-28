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
		bool endGameInput;

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
			Console.WriteLine("Rules of Rock, Paper, Scissors, Lizard, Spock\n1. Scissors cuts Paper\n2. Paper covers Rock\n3. Rock crushes Lizard\n4. Lizard poisons Spock\n5. Spock smashes Scissors\n6. Scissors decapitates Lizard\n7. Lizard eats Paper\n8. Paper disproves Spock\n9. Spock vaporizes Rock\n");
		}

		public void RunGame()
		{
			ChooseGameType();
			InitializeGame();
			
		}

		public string ChooseGameType()
		{
			bool endGameInput = false;
			while (!endGameInput)
			{
				Console.WriteLine("Do you want to proceed to Single Player? Type 'yes' to play against AI or 'no' to play against another person!");
				gameType = Console.ReadLine();
				Console.WriteLine("\n");
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
				Console.WriteLine("\n");
				Console.Clear();
				ScoreCheck();
			}

			else if (gameType == "no")
			{
				player1 = new Human();
				player2 = new Human();
				player1.InputName();
				Console.WriteLine("\n");
				player2.InputName();
				Console.Clear();
				//Console.WriteLine("\n");
				ScoreCheck();
			}
		}

		public void ScoreCheck()
		{
			pointsToWin = 2;
			if (player1.score >= pointsToWin)
			{
				Console.WriteLine($"{player1.playerName} has won the best of three game!");
				InitializeEndGame();
			}

			else if (player2.score >= pointsToWin)
			{
				Console.WriteLine($"{player2.playerName} has won the best of three game!");
				InitializeEndGame();
			}

			else
			{
				PlayGame();
			}
		}

		public void PlayGame()
		{
			DisplayRules();
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
			if (player1.selectedGesture == player2.selectedGesture)
			{
				Console.WriteLine("You two chose the same gesture, it's a draw! Try again");
			}

			else if (player1.selectedGesture == "rock" && player2.selectedGesture == "scissors")
			{
				Console.WriteLine("Rock crushes Scissors!");
				player1.score += 1;
			}

			else if (player1.selectedGesture == "rock" && player2.selectedGesture == "lizard")
			{
				Console.WriteLine("Rock crushes Lizard!");
				player1.score += 1;
			}

			else if (player1.selectedGesture == "rock" && player2.selectedGesture == "paper")
			{
				Console.WriteLine("Paper covers Rock!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "rock" && player2.selectedGesture == "spock")
			{
				Console.WriteLine("Spock vaporizes Rock!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "paper" && player2.selectedGesture == "scissors")
			{
				Console.WriteLine("Scissors cuts Paper!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "paper" && player2.selectedGesture == "rock")
			{
				Console.WriteLine("Paper covers Rock!");
				player1.score += 1;
			}

			else if (player1.selectedGesture == "paper" && player2.selectedGesture == "lizard")
			{
				Console.WriteLine("Lizard eats Paper!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "paper" && player2.selectedGesture == "spock")
			{
				Console.WriteLine("Paper disproves Spock!");
				player1.score += 1;
			}

			else if (player1.selectedGesture == "scissors" && player2.selectedGesture == "paper")
			{
				Console.WriteLine("Scissors cuts Paper!");
				player1.score += 1;
			}

			else if (player1.selectedGesture == "scissors" && player2.selectedGesture == "rock")
			{
				Console.WriteLine("Rock crushes Scissors!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "scissors" && player2.selectedGesture == "spock")
			{
				Console.WriteLine("Spock smashes Scissors!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "scissors" && player2.selectedGesture == "lizard")
			{
				Console.WriteLine("Scissors decapitates Lizard!");
				player1.score += 1;
			}

			else if (player1.selectedGesture == "lizard" && player2.selectedGesture == "spock")
			{
				Console.WriteLine("Lizard poisons Spock!");
				player1.score += 1;
			}

			else if (player1.selectedGesture == "lizard" && player2.selectedGesture == "scissors")
			{
				Console.WriteLine("Scissors decapitates Lizard!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "lizard" && player2.selectedGesture == "rock")
			{
				Console.WriteLine("Rock crushes Lizard!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "lizard" && player2.selectedGesture == "paper")
			{
				Console.WriteLine("Lizard eats Paper!");
				player1.score += 1;
			}

			else if (player1.selectedGesture == "spock" && player2.selectedGesture == "lizard")
			{
				Console.WriteLine("Lizard poisons Spock!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "spock" && player2.selectedGesture == "scissors")
			{
				Console.WriteLine("Spock smashes Scissors!");
				player1.score += 1;
			}

			else if (player1.selectedGesture == "spock" && player2.selectedGesture == "paper")
			{
				Console.WriteLine("Paper disproves Spock!");
				player2.score += 1;
			}

			else if (player1.selectedGesture == "spock" && player2.selectedGesture == "rock")
			{
				Console.WriteLine("Spock vaporizes Rock!");
				player1.score += 1;
			}

			else
			{
				ScoreCheck();
			}
		}

		public void ShowMatchTally()
		{
			Console.WriteLine($"The current tally is {player1.playerName}: {player1.score} vs {player2.playerName}: {player2.score}. Press Enter to go to next phase.");
			Console.ReadLine();
			Console.Clear();
			ScoreCheck();
		}

		public string EndGame()
		{
			endGameInput = false;
			string newGame = "";
			while (!endGameInput)
			{
				Console.WriteLine($"That is the end of the game! Type '0' to replay the game with same players or type '1' to completely restart the game. Press any other key to exit the application\n\nLive long and prosper!");
				newGame = Console.ReadLine();
				switch (newGame)
				{
					case "0":
						endGameInput = true;
						return newGame;
					case "1":
						endGameInput = true;
						return newGame;
					default:
						Environment.Exit(0);
						break;
				}
			}
			return newGame;
		}

		public void InitializeEndGame()
		{
			
			string result = EndGame();
			if (result == "0")
			{
				player1.score = 0;
				player2.score = 0;
				ScoreCheck();
			}

			else if (result == "1")
			{
				player1.score = 0;
				player2.score = 0;
				RunGame();
			}
		}


	}
}
