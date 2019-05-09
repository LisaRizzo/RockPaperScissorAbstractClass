using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Rock_Paper_Scissors
{
  class Rookie : Player
  {
    public override string generateRoshambo()
    {
      List<string> RockPaperScissors = new List<string>() {
        "Scissors",
        "Rock",
        "Paper",};

      for (int i = 0; i < RockPaperScissors.Count; i++)
      {
        Console.WriteLine($"{i + 1}. {RockPaperScissors[i]}");
      }

       int y = Validator.GetIntFromUser("Select a weapon of choice: ");
       string randomRoshambo = RockPaperScissors[y - 1];

       //randomly select rock, paper or scissors
       return randomRoshambo;
    }
  }
}
