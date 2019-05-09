using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Rock_Paper_Scissors
{
  class Randy : Player
  {
    public Random RandomNumber { get; set; }

    public override string generateRoshambo()
    {
      List<string> RockPaperScissors = new List<string>() {
        "Rock",
        "Paper",
        "Scissors" };

      Random rand = new Random();
      int randomNumber = rand.Next(0, 3);

      string randomRoshambo = RockPaperScissors[randomNumber];

      //randomly select rock, paper or scissors
      return randomRoshambo;
    }
  }
}
