using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    public class GameCon : EventArgs
    {
        DeckImageFactory ImageFactory = new DeckImageFactory();
        DeckValueFactory DeckValueFactory = new DeckValueFactory();
        public event EventHandler PlayerTurnEvent;
        Player player = new Player("Bastarsan");

       private List<ICard> deck;

        public GameCon(CardTypes cardTypes, string playerName)
        {

            Player player = new Player(playerName);
            switch (cardTypes)
            {
                case CardTypes.Value:
                    deck = new List<ICard>(DeckValueFactory.ReturnDeck());
                    break;
                case CardTypes.Image:
                    deck = new List<ICard>(ImageFactory.ReturnNewDeck());
                    break;
                default:
                    break;
            }
        }

        public List<ICard> GetCards()
        {
            return deck;
        }
        public void StartGame()
        {
            Thread t = new Thread(NextTurn);
            t.Start();

            player = new Player("Hogn");
           
        }

        public void NextTurn()
        {
            PlayerTurnEvent?.Invoke(this, new PlayerEventArgs(player.Name));
            
        }




    }
}
