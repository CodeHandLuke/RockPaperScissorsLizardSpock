using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
	public class Human : Player
	{
		//member variables
		public string gestureChoice;
		public bool isInputValid;

		//constructor
		public Human()
		{
			playerName = null;
		}

		//member methods

		public string ValidateChoice()
		{
			isInputValid = false;
			while (!isInputValid)
			{
				Console.WriteLine($"{playerName}, please choose which gesture you want throw for your turn by typing in a number from 0 - 4.\n0:rock\n1:paper\n2:scissors\n3:lizard\n4:Spock");
				gestureChoice = Console.ReadLine();
				switch (gestureChoice)
				{
					case "0":
						isInputValid = true;
						return gestureChoice;
					case "1":
						isInputValid = true;
						return gestureChoice;
					case "2":
						isInputValid = true;
						return gestureChoice;
					case "3":
						isInputValid = true;
						return gestureChoice;
					case "4":
						isInputValid = true;
						return gestureChoice;
					default:
						Console.WriteLine("Invalid Input, Try again.");
						break;
				}
			}
			return gestureChoice;
		}
		public override void GetGesture(List<string> gestures)
		{
			ValidateChoice();
			this.selectedGesture = GetGestureFromList(Convert.ToInt32(gestureChoice), gestures);
			Console.WriteLine("\n");
			Console.WriteLine($"You chose {selectedGesture}!\nPress enter to clear the console and go to next step");
			Console.ReadLine();
			Console.Clear();
		}

		public string GetGestureFromList(int index, List<string> gestures)
		{
			return gestures[index];
		}


	}
}
