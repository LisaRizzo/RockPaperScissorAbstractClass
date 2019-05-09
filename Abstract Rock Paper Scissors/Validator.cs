using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Rock_Paper_Scissors
{
  class Validator
  {
    /// Prompts user with message, gets valid response and returns value(int).
    public static int GetIntFromUser(string message)
    {
      Console.Write(message);
      try
      {
        return int.Parse(Console.ReadLine());

      }
      catch(ArgumentOutOfRangeException)
      {
        Console.WriteLine("I'm sorry! Please select 1-3." + message);
        return GetIntFromUser(message);
      }

      catch (Exception e)
      {
        Console.WriteLine("I'm sorry! I didn't understand!" + message);
        return GetIntFromUser(message);
      }
    }

    // Pass string into method with message. 
    //Add's Yes or No to it and writes it to console. 
    public static bool GetYesOrNoFromUser(string prompt)
    {
      Console.WriteLine(prompt.Trim() + " (Yes or No)");
      string answer = Console.ReadLine().ToLower();
      if (answer == "y" || answer == "yes")
      {
        return true;
      }
      else if (answer == "n" || answer == "no")
      {
        return false;
      }
      else
      {
        Console.WriteLine("Invalid Input!");
        return GetYesOrNoFromUser(prompt);
      }
    }
  }
}
