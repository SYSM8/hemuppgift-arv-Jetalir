using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        public int Pins { get; set; }
        public int Setup(int pins) // Startar spelet med antal angivna pins
        {
            return Pins = pins;
        }
        public int TakePins(int pins) //Antal pins spelaren tar
        {
            return Pins -= pins;
        }

        public int GetNoPins() // Skriver ut pins
        {
            return Pins;
        }
    }
}
