using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Rock_Paper_Scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Kawi-Bawi-Bo, the Korean version of Rock-Paper-Scissors.");
      Console.Write("Enter your name: ");
      string name = Console.ReadLine();

      bool run = true;
      while (run)
      {
        RPSApp ra = new RPSApp();
        ra.Run();
        run = Validator.GetYesOrNoFromUser("Would you like to play again?");
      }
    }
  }
}
