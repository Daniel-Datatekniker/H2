using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
   public abstract class Card : ICard
    {
        //Attribute
        private string value;

        //Properties

        //constructor
        public Card(string val)
        {
            value = val;
        }

        //Methods
        public virtual string GetValue()
        {
            return value;
        }

    }
}
