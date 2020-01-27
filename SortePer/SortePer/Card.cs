using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
   abstract class Card
    {
        private string name;
        //private ConsoleColor color;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public ConsoleColor Color
        // {
        //     get { return color; }
        //     set { color = value; }
        // }

        public Card(string cardName)
        {
            name = cardName;
        }


    }
}
