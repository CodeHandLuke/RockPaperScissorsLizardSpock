using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
	public class Computer : Player
	{
		//member variables
		Random rng;
		public int gestureChoice;

		//constructor
		public Computer()
		{
			rng = new Random();
			playerName = "Turing";
		}

		public override void GetGesture(List<string> gestures)
		{
			int x = rng.Next(0, 5);
			selectedGesture = gestures[x];
			Console.WriteLine($"{playerName} chose {selectedGesture}!");
			Console.ReadLine();
		}
	}
}
