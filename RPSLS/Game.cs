using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
	public class Game
	{
		List<string> choices = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

		//member variables


		//constructor
		public Game()
		{
			DisplayRules();
		}


		//member methods
		public void DisplayRules()
		{
			Console.WriteLine("Rules\n1. Scissors cuts Paper\n2. Paper covers Rock\n3. Rock crushes Lizard\n4. Lizard poisons Spock\n5. Spock smashes Scissors\n6. Scissors decapitates Lizard\n7. Lizard eats Paper\n8. Paper disproves Spock\n9. Spock vaporizes Rock\n");
		}
	}
}
