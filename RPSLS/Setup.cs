using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
	public class Setup
	{
		public string playerName;
		public string playerTwoName;
		public int gameType;


		//constructor
		public Setup()
		{

		}


		//member methods
		public void ChooseGameType()
		{
			Console.WriteLine("Choose your game: Type '1' for single player against AI or '2' for multiplayer against a friend.");
			gameType = Convert.ToInt32(Console.ReadLine());
		}

		public void CheckGameType()
		{
			if (gameType == 1)
			{
				Console.WriteLine("You have chosen singleplayer, you will face the computer! Press Enter...");
				Console.ReadLine();
			}

			else if (gameType == 2)
			{
				Console.WriteLine("You have chosen mutliplayer, you will face another person! Press Enter...");
				Console.ReadLine();
			}

			else
			{
				Console.WriteLine("Invalid input, please choose only 1 or 2");
				CheckGameType();
			}
		}

		public void InitializeGameType()
		{
			if (gameType == 1)
			{
				InputNamesSingle();
			}

			else
			{
				InputNamesMulti();
			}
		}

		public void InputNamesSingle()
		{
			Console.WriteLine("Please enter a name for Player 1");
			playerName = Console.ReadLine();
			playerTwoName = "Computer";
		}

		public void InputNamesMulti()
		{
			Console.WriteLine("Please enter a name for Player 1");
			playerName = Console.ReadLine();
			Console.WriteLine("Please enter a name for Player 2");
			playerTwoName = Console.ReadLine();
		}
	}
}
