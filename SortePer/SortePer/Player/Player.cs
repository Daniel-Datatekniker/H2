using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    abstract class Player
    {
        //Attribute
        private string name;
        private List<DisneyCard> hand = new List<DisneyCard>();
        static Random ran = new Random();
        private int cardLeft;



        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<DisneyCard> Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        public int CardLeft
        {
            get
            {
                cardLeft = hand.Count;
                return cardLeft;
            }


        }
        //Constructor


        public Player(string playerName)
        {
            Name = playerName;
        }

        public DisneyCard GiveCard()
        {
            if (hand.Count > 0)
            {
                int randomnumber = ran.Next(0, hand.Count);
                DisneyCard giveaway = hand[randomnumber];
                hand.RemoveAt(randomnumber);

            return giveaway;
            }
            else
            {
                return null;
            }
        }

        public string Pair()
        {
            //Check om den findes allerede;

            List<DisneyCard> pairs = new List<DisneyCard>();
            if (hand.Count != 0)
            {
                List<DisneyCard> temp = new List<DisneyCard>();
                List<string> names = new List<string>();
                //  List<DisneyCard> temp2 = new List<DisneyCard>();

                for (int i = 0; i < hand.Count; i++)
                {
                    temp = hand.FindAll(o => o.Name == hand[i].Name);
                    if (temp.Count > 1)
                    {

                        foreach (var item in temp)
                        {
                            pairs.Add(item);
                            hand.Remove(item);
                        }

                    }
                }
            }


          
            if (pairs.Count > 0)
            {
                string returnstring = "";
                foreach (DisneyCard cardss in pairs)
                {
                    returnstring += $"{cardss.Name}\n";
                }
                return $"paired\n{returnstring} ";

            }
            else
            {
                return "Nothing to pair";
            }


        }

        public string AddCard(DisneyCard disneyCard)
        {
            if (hand.Exists(o=> o.Name == disneyCard.Name))
            {
                Hand.RemoveAll(o => o.Name == disneyCard.Name);
                return $"{Name} drawed = {disneyCard.Name} & paired it";
            }
            else
            {
                hand.Add(disneyCard);
                return $"New card = {disneyCard.Name}";
            }
            
          
        }




    }
}
