using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    class CardText
    {
        private List<string> disneyCardNames = new List<string>()
        {
             "Sorte Per", "Micky Mouse",
            "Anders And", "Andersine",
            "Mogli", "Fedtmule", "Max",
            "Mulan", "Mushu", "Rip", "Rap", "Rup",
            "Onkel Joakim", "Aladin", "Doris", 

        };

        public List<string> DisneyCardNames
        {
            get { return disneyCardNames; }
        }


        public CardText()
        {

        }
    }
}
