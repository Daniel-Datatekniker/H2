using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    class Human : Player
    {
        /// <summary>
        /// Creating human, requirre a name
        /// </summary>
        /// <param name="playerName"></param>
        public Human(string playerName) : base(playerName)
        {
            Name = playerName;
        }
    }
}
