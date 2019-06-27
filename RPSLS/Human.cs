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
		public int gestureChoice;

		//constructor
		public Human()
		{
			playerName = null;
		}

		//member methods
		public override void GetGesture(List<string> gestures)
		{
			Console.WriteLine("Choose which gesture you want throw for your turn by typing in a number from 0 - 4.\n0:rock\n1:paper\n2:scissors\n3:lizard\n4:Spock");
			gestureChoice = Convert.ToInt32(Console.ReadLine());
			this.selectedGesture = GetGestureFromList(gestureChoice, gestures);
			Console.WriteLine($"{playerName} chose {selectedGesture}!\nPress enter to clear the console and pass to next player");
			Console.ReadLine();
			Console.Clear();
		}

		public string GetGestureFromList(int index, List<string> gestures)
		{
			return gestures[index];
		}
	}
}
