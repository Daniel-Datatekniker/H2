using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    class CardText
    {
        /// <summary>
        /// List of names for the disney card
        /// </summary>
        private List<string> disneyCardNames = new List<string>()
        {
             "Bad Pete", "Micky Mouse",
            "Donald Duck", "Daisy Duck",
            "Mowsgli", "Goofy", "Max",
            "Mulan", "Mushu", "Rip", "Rap", "Rup",
            "Scrooge McDuck", "Aladin", "Dorit", 

        };
        /// <summary>
        /// Return list of disney names
        /// </summary>
        public List<string> DisneyCardNames
        {
            get { return disneyCardNames; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CardText()
        {

        }
    }
}
