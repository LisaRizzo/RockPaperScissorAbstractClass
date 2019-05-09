using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Rock_Paper_Scissors
{
  abstract class Player
  {
    public string Name { get; set; }
    public string Roshambo { get; set; }

    public abstract string generateRoshambo();
  }
}
