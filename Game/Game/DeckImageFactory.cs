using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class DeckImageFactory
    {

        Queue<ICard> deck = new Queue<ICard>();
        public DeckImageFactory()
        {
            List<ImageCard> imageCards = new List<ImageCard>()
            {
            new ImageCard("bear"),
            new ImageCard("Bee"),
            new ImageCard("Bull"),
            new ImageCard("Camel"),
            new ImageCard("Crab"),
            new ImageCard("Crocodile"),
            new ImageCard("Dog"),
            new ImageCard("Duck"),
            new ImageCard("Fish"),
            new ImageCard("grasshopper"),
            new ImageCard("Ladybug"),
            new ImageCard("Mouse"),
            new ImageCard("Ostrich"),
            new ImageCard("Owl"),
            new ImageCard("Cat")

        };

            List<ImageCard> copy = new List<ImageCard>(imageCards);
            imageCards.AddRange(imageCards);


            //imageCards = new List<ImageCard>(ShuffleList(imageCards));
            imageCards.Remove(imageCards.Find(o => o.GetValue() == "Cat"));
            //Shuffle deck here
            deck = new Queue<ICard>(imageCards);
        }


        public Queue<ICard> ReturnNewDeck()
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
