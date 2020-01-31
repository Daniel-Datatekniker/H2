using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Banker : INumberGenerator
    {
        //Atributes
        private string name = "John";
        List<Card> allcards = new List<Card>();
        private Random ran = new Random();

        //Properties
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        //Constructor
        public Banker(string bankerName)
        {
            Name = bankerName;
        }

        public Card CreateCard(CardType type)
        {
            Card card = new MasterCard();

            int[] prefix;

            switch (type)
            {
                case CardType.Maestro:
                    prefix = new int[4] { 5, 5, 5, 5 };
                    card = new Maestro("John", GenerateAccountNumber(), GeneratCardNumber(16, prefix));
                    break;
                case CardType.Mastercard:
                    prefix = new int[2] { 5, 1 };
                    card = new MasterCard("John", GenerateAccountNumber(), GeneratCardNumber(16, prefix));
                    break;
                case CardType.Visa:
                    prefix = new int[1] {4};
                    card = new Visa("John", GenerateAccountNumber(), GeneratCardNumber(16, prefix));
                    break;
                case CardType.VisaElectron:
                    prefix = new int[4] { 4, 0, 2, 6 };
                    card = new VisaElectron("John", GenerateAccountNumber(), GeneratCardNumber(16, prefix));
                    break;
                case CardType.Debit:
                    prefix = new int[4] { 2, 4, 0, 0 };
                    card = new Debit("John", GenerateAccountNumber(), GeneratCardNumber(16, prefix));
                    break;
                default:
                    break;
            }

            return card;
        }

        public int[] GeneratCardNumber(int length, int[] prefix)
        {
            int[] temp = new int[length];

            for (int i = 0; i < length; i++)
            {
                temp[i] = ran.Next(0, 9);
            }

            for (int j = 0; j < prefix.Length; j++)
            {
                temp[j] = prefix[j];
            }


            return temp;
        }

        public int[] GenerateAccountNumber()
        {
            int[] temp = new int[14];

            for (int i = 0; i < 14; i++)
            {
                temp[i] = ran.Next(0, 9);
            }

            return temp;
        }
    }
}
