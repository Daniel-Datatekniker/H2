using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        //Attributes
        private string name;
        private int[] cardNumber = new int[16];
        private DateTime experirationDate;
        private int[] accountNumber = new int[14];
        private double money;
        private double minMoney = 0;
        protected Random ran = new Random();

        //Properties
        public int[] CardNumber
        {
            get { return cardNumber; }
            private set { cardNumber = value; }
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        public DateTime ExperiationDate
        {
            get { return experirationDate; }
            protected set { experirationDate = value; }
        }
        public int[] AccountNumber
        {
            get { return accountNumber; }
            protected set { accountNumber = value; }
        }

        public double Money
        {
            get { return money; }
            set
            {
                if (value < minMoney)
                {

                    money = minMoney;
                }
                else
                {
                    money = value;
                }
            }
        }
        public double MinMoney
        {
            get
            {
                return minMoney = 0;
            }
            protected set
            {
                minMoney = value;
            }
        }


        //Constructor
        public Card()
        {

        }

        public Card(string humanName, int[] cardnumb, int[] accountNumb)
        {
            name = humanName;
            cardNumber = cardnumb;
            AccountNumber = accountNumb;
        }

    }
}
