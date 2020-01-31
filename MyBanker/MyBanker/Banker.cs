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
            int[] cardNum;
            string prefixString;
            int count = 0;

            switch (type)
            {
                case CardType.Maestro:
                    card = new Maestro();
                    cardNum = GenerateNumber(card.CardNumber);
                     prefixString = card.Prefix[ran.Next(0, card.Prefix.Count)].ToString();
                     count = 0;
                    foreach (char t in prefixString)
                    {
                        cardNum[count] = Int32.Parse(t.ToString());
                        count++;
                    }
                  card = new MasterCard("John", cardNum, GenerateNumber(card.AccountNumber));
                    break;
                case CardType.Mastercard:
                    card = new MasterCard();
                    cardNum = GenerateNumber(card.CardNumber);
                    prefixString = card.Prefix[ran.Next(0, card.Prefix.Count)].ToString();
                     count = 0;
                    foreach (char t in prefixString)
                    {
                        cardNum[count] = Int32.Parse(t.ToString());
                        count++;
                    }
                    card = new MasterCard("John", cardNum, GenerateNumber(card.AccountNumber));
                    break;

                case CardType.Visa:
                    card = new Visa();
                    cardNum = GenerateNumber(card.CardNumber);
                    prefixString = card.Prefix[ran.Next(0, card.Prefix.Count)].ToString();
                    count = 0;
                    foreach (char t in prefixString)
                    {
                        cardNum[count] = Int32.Parse(t.ToString());
                        count++;
                    }
                    card = new Visa("John", cardNum, GenerateNumber(card.AccountNumber));
                    break;
                case CardType.VisaElectron:
                    card = new VisaElectron();
                    cardNum = GenerateNumber(card.CardNumber);
                    prefixString = card.Prefix[ran.Next(0, card.Prefix.Count)].ToString();
                    count = 0;
                    foreach (char t in prefixString)
                    {
                        cardNum[count] = Int32.Parse(t.ToString());
                        count++;
                    }
                    card = new VisaElectron("John", cardNum, GenerateNumber(card.AccountNumber));
                    break;
                case CardType.Debit:
                    card = new Debit();
                    cardNum = GenerateNumber(card.CardNumber);
                    prefixString = card.Prefix[ran.Next(0, card.Prefix.Count)].ToString();
                    count = 0;
                    foreach (char t in prefixString)
                    {
                        cardNum[count] = Int32.Parse(t.ToString());
                        count++;
                    }
                    card = new Debit("John", cardNum, GenerateNumber(card.AccountNumber));
                    break;
                default:
                    break;
            }
            
            return card;
        }

        public int[] GenerateNumber(int[] Array)
        {
           

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = ran.Next(0, 9);
            }


            return Array;
        }
    }
}
