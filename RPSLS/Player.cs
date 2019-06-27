using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
	public abstract class Player
	{
		//member variables
		public string playerName;
		public string selectedGesture;
		public int score;

		//constructor
		public Player()
		{
			this.selectedGesture = null;
			this.score = 0;
		}

		//member methods
		public void InputName()
		{
			Console.WriteLine("Please enter a name for Player");
			playerName = Console.ReadLine();
		}

		public abstract void GetGesture(List<string> gestures);
	}
}
