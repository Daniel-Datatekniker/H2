using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Human
    {
        //Attribute
        private string name;
        private Card card; 

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Card Card
        {
            get { return card; }
            set { card = value; }
        }

        //Constructor
        public Human(string hName)
        {
            name = hName;
        }


        //Methods
        public void UseMoney(double spend)
        {
            Card.Money -= spend;
        }



    }
}
