using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    class DisneyCard : Card
    {
        /// <summary>
        /// Create a DisneyCard rquirre a string input with name
        /// </summary>
        /// <param name="cardName"></param>
        public DisneyCard(string cardName) : base(cardName)
        {
            Name = cardName;
        }
    }
}
