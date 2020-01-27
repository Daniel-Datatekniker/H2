using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    class Log
    {
        //Attribute
        private ErrorCode lastError;

        //Properties
        /// <summary>
        /// Giving you the last error code saved
        /// </summary>
        public ErrorCode LastError
        {
            get { return lastError; }

        }

        /// <summary>
        /// Give you the player limit
        /// </summary>
        public string PlayerLimit = "You need min 2 players, or 1 player and 1 ai,  max is 4!";
        /// <summary>
        /// Input your name
        /// </summary>
        public string InputPlayerName = "Please input your name";
        /// <summary>
        /// Placeholder for playername
        /// </summary>
        public string PlayerName = "";
        /// <summary>
        /// How many AI
        /// </summary>
        public string InputAI = "Input how many Ai's";
        /// <summary>
        /// Game is starting
        /// </summary>
        public string GameStart = "Game is starting ";

        /// <summary>
        /// Menu for humans
        /// </summary>
        public string HumanMenu = "Press [1] to check your cards.\nPress [2] to pair all cards\nPress [3] to end turn";

        public string WelcomeMessage = "Welcome";
        /// <summary>
        /// Input errror code to recieve a error message
        /// </summary>
        /// <param name="incError"></param>
        /// <returns></returns>
        public string ErrorText(ErrorCode incError)
        {
            string errorReturn;

            switch (incError)
            {
                case ErrorCode.NotEnoughPlayers:
                    errorReturn = "Not enough players, please input atleast 2 human, or 1 human and 1 ai";
                    break;
                case ErrorCode.WrongInputType:
                    errorReturn = "Wrong input, please try again";
                    break;
                case ErrorCode.Success:
                    errorReturn = "successfully crated players";
                    break;
                default:
                    errorReturn = "";
                    break;
            }

            lastError = incError;
            return errorReturn;
        }

        /// <summary>
        /// Clearing the console
        /// </summary>
        public void ClearConsole()
        {
            Console.Clear();
        }

        /// <summary>
        /// Give list of all card names in current deck
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public string PrintCards(List<DisneyCard> cards)
        {
            
            string returnstring = "";
            for (int i = 0; i < cards.Count; i++)
            {
                returnstring += $"{cards[i].Name}\n";
            }
            return returnstring;
        }

    }
}
