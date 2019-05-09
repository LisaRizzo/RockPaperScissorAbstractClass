using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Rock_Paper_Scissors
{
  class RPSApp
  {
    public void Run()
    {
      Rookie rrr = new Rookie();
      string userRPS = rrr.generateRoshambo();
      Console.WriteLine("You selected " + userRPS + "!");
      Console.WriteLine();

      string rockieRPS = "";
      string randyRPS = "";

      bool repeat1 = true;
      while (repeat1 == true)
      {
        Console.Write("Which opponent do you want to battle? Rockie(1) or Randy(2)? ");
        string userInput = Console.ReadLine().ToLower();
 
        Console.WriteLine();

        if (userInput == "rockie" || userInput == "1")
        {
          Rockie rr = new Rockie();
          rockieRPS = rr.generateRoshambo();
          Console.WriteLine("Rockie selected Rock!");
          break;
        }
        else if (userInput == "randy" || userInput == "2")
        {
          Randy r = new Randy();
          randyRPS = r.generateRoshambo();
          Console.WriteLine("Randy selected " + randyRPS);
          break;
        }
        else
        {
          Console.WriteLine("Are you getting scared? Try again!");
          continue;
        }
      }

      if (userRPS == rockieRPS || userRPS == randyRPS)
      {
        Console.WriteLine("You tied!");
      }
      else if ((userRPS == "Paper" && rockieRPS == "Rock") || (userRPS == "Paper" && randyRPS == "Rock"))
      {
        Console.WriteLine("You Won!");
      }
      else if (userRPS == "Rock" && randyRPS == "Scissors")
      {
        Console.WriteLine("You Won!");
      }
      else if (userRPS == "Scissors" && randyRPS == "Paper")
      {
        Console.WriteLine("You Won!");
      }
      else if (userRPS == "Paper" && randyRPS == "Rock")
      {
        Console.WriteLine("You Won!");
      }
      else
      {
        Console.WriteLine("You lost!");
      }

    }
  }
}
