using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
	class Program
	{
		static void Main(string[] args)
		{   //For this project I want to create a RPSLS game that accounts for whichever choice the player makes and have them win a best of three game.
			//First create an inheritance class for the player to encompass both the human players and the AI
			//Create the Gesture class with the variable of gesture choice
			//Create a list that will have all 5 choices for the hand gestures
			//For each turn, the player will choose one of the five choices for RPSLS, which will be checked by a switch case and then lowercased
			//Show a winner depending on which choice a player made, then give that player 1 point. 
			//Have the overall winner be the player that won two out of three games, which the score should be held in a total.
			//Create an AI that will make a choice determined by a random number generated between one and five. That number will correlate to the gesture listed at the position of the playerChoice list

			//Setup
			Game newGame = new Game();

			Setup setup = new Setup();
			setup.ChooseGameType();
			setup.CheckGameType();
			setup.InitializeGameType();

			//Gameplay loop


			//clean up

		}
	}
}
