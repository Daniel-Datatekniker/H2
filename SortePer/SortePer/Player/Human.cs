using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    class Human : Player
    {
        public Human(string playerName) : base(playerName)
        {
            Name = playerName;
        }
    }
}
