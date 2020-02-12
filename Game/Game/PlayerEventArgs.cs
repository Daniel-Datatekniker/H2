using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
  public  class PlayerEventArgs : EventArgs
    {
        public string PlayerTurn { get; set; }


        //Constructor med parameter
        public PlayerEventArgs(string name)
        {
            PlayerTurn =  name;
        }

    }
}
