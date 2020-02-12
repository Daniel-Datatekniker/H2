using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class DeckValueFactory
    {
        private Queue<ICard> deck = new Queue<ICard>();

        public DeckValueFactory()
        {
            List<ValueCard> valueCards = new List<ValueCard>();

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    if (i == 1)
                    {
                        valueCards.Add(new ValueCard($"C{j}"));
                    }
                    else if (i == 2)
                    {
                        valueCards.Add(new ValueCard($"D{j}"));
                    }
                    else if (i == 3)
                    {
                        valueCards.Add(new ValueCard($"H{j}"));
                    }
                    else if (i == 4)
                    {
                        valueCards.Add(new ValueCard($"S{j}"));
                    }
                }
                if (i == 5)
                {
                    valueCards.Add(new ValueCard($"J"));
                }
            }


            //Shuffle deck here
            valueCards = new List<ValueCard>(ShuffleList(valueCards));
            deck = new Queue<ICard>(valueCards);

        }
        public Queue<ICard> ReturnDeck()
        {
            return deck;
        }

        

        /// <summary>
        /// Takes a list and shuffle it, then return the list
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="inputList"></param>
        /// <returns></returns>
        private List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }
    }
}
