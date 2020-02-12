using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player
    {
        private string name;


        public string Name
        {
            get { return name; }
            private set { name = value; }
        }


        public Player(string playerName)
        {
            name = playerName;
        }
    }
}
