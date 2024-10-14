using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        public string Userid;

        public Player(string userid)
        {
            Userid = userid;
        } 
        public string getUserid()
        {
            return Userid;
        }
        public int TakePins(Board board, int pins) // Från board den ska ta bort antal pins från totalen
        {
            return board.TakePins(pins);
        }


    }
}
