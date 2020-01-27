using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    class PlayerManager
    {
        private int humanCount;
        private int aiCount;
        private int playerAmount;
        private bool isPlayerCreated;


        //Properties
        public int HumanCount
        {
            get { return humanCount; }
            set
            {
                humanCount = value;
            }
        }

        public int AiCount
        {
            get { return aiCount; }
            set
            {
                if (value > 4)
                {
                    aiCount = 4;
                }
                else
                {
                    aiCount = value;
                }
            }
        }

        public int PlayerAmount
        {
            get
            {
                playerAmount = aiCount + humanCount;
                return playerAmount;
            }

        }

        public bool IsPlayerCreated
        {
            get { return isPlayerCreated; }
        }

        public List<Player> Players = new List<Player>();

        public PlayerManager()
        {

        }



        public bool CreatePlayers(List<DisneyCard> disCards, string playername)
        {
            if (humanCount > 0 && aiCount > 0)
            {
                for (int i = 0; i < humanCount; i++)
                {

                    Players.Add(new Human($"{playername}"));
                }

                for (int i = 0; i < aiCount; i++)
                {
                    Players.Add(new Ai($"AI {i}"));
                }
                DealCards(disCards);
                isPlayerCreated = true;
                return true;
            }
            else
            {
                isPlayerCreated = false;
                return false;
            }

        }

        private void DealCards(List<DisneyCard> dcard)
        {
            List<DisneyCard> cards = dcard;
            int cardPerPlayer = (int)Math.Floor((decimal)cards.Count / (decimal)PlayerAmount);



            for (int i = 0; i < Players.Count; i++)
            {
                //int cardStartIndex = i == 0 ? 0 : cardPerPlayer * i;
                Players[i].Hand.AddRange(cards.GetRange(0, cardPerPlayer));
                cards.RemoveRange(0, cardPerPlayer);


            }

            do
            {
                for (int j = 0; j < Players.Count; j++)
                {
                    if (cards.FirstOrDefault() != null)
                    {
                        Players[j].Hand.Add(cards[0]);
                        cards.RemoveAt(0);
                    }
                    else
                        break;
                }
            } while (cards.Count > 0);


        }

        //public string CheckPlayerWon()
        //{
        //    string returnStirng = "";
        //    List<Player> Winners = new List<Player>();
        //    foreach (Player play in Players)
        //    {
        //        if (play.Hand.Count == 0)
        //        {
        //            Winners.Add(play);
        //        }

        //    }

        //    foreach (Player winner in Winners)
        //    {
        //        Players.Remove(winner);
        //        returnStirng += $"{winner.Name} has 0 card left and is out of the game\n";
        //    }

        //    return returnStirng;
        //}


 
     

    }
}
