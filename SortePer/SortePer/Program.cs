using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object og CardManager where cards get created and shuffel
            CardManager cardManager = new CardManager();
            //Creating object og PlayerManager, it handle Players giving them cards, 
            PlayerManager playerManager = new PlayerManager();
            Random ran = new Random();
            Log textlog = new Log();


            while (playerManager.IsPlayerCreated == false)
            {
                Console.Clear();
                Console.WriteLine(textlog.PlayerLimit);
                try
                {
                    if (textlog.PlayerName.Length == 0)
                    {
                        Console.WriteLine(textlog.InputPlayerName);
                        textlog.PlayerName = Console.ReadLine();
                    }
                    playerManager.HumanCount = 1;
                    textlog.ClearConsole();

                    Console.WriteLine(textlog.InputAI);
                    int Ais = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                    if (Ais > 4)
                    {
                        Console.WriteLine("Setting ai to 4");
                        Console.ReadKey();
                    }
                    playerManager.AiCount = Ais;

                    textlog.ErrorText(ErrorCode.Success);
                    textlog.ClearConsole();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    textlog.ClearConsole();
                    Console.WriteLine(textlog.ErrorText(ErrorCode.WrongInputType));
                    Console.ReadKey();
                }

                if (textlog.LastError == ErrorCode.Success)
                {
                    playerManager.CreatePlayers(cardManager.DisneyCards, textlog.PlayerName);
                    if (playerManager.IsPlayerCreated)
                    {
                        Console.WriteLine(textlog.ErrorText(ErrorCode.Success));
                        Console.ReadKey();
                        //exampel
                        if (playerManager.Players[0] is Player)
                        {
                            Console.WriteLine("ya");
                        }
                    }
                    else
                    {

                        Console.WriteLine(textlog.ErrorText(ErrorCode.NotEnoughPlayers));
                        Console.ReadKey();
                    }

                }

            }

            //foreach (var item in cardManager.DisneyCards)
            //{
            //    Console.WriteLine(item.Name);
            //}




            bool gamerunning = true;
            do
            {
                for (int i = 0; i < playerManager.Players.Count; i++)
                {
                    bool IPaired = false;

                    bool pickCard = false;

                    if (playerManager.Players[i] is Human && playerManager.Players[i].Hand.Count > 0)
                    {
                        int menupick = 0;
                       
                        do
                        {
                            try
                            {

                                textlog.ClearConsole();
                                Console.WriteLine($"{playerManager.Players[i].Name}\n{textlog.HumanMenu}");
                                menupick = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                                textlog.ClearConsole();
                                switch (menupick)
                                {
                                    case 1:
                                        Console.WriteLine(textlog.PrintCards(playerManager.Players[i].Hand));
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        string pair = $"{playerManager.Players[i].Name} {playerManager.Players[i].Pair()}";
                                        if (pair.Contains("paired"))
                                        {
                                            IPaired = true;
                                        }

                                        Console.WriteLine(pair);


                                        Console.ReadKey();
                                        break;

                                    case 3:

                                        if (IPaired == false)
                                        {
                                            Console.WriteLine(playerManager.Players[i].AddCard(playerManager.Players.Last().GiveCard()));
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ending Turn");
                                        }
                                        Console.ReadKey();
                                        pickCard = true;
                                        break;
                                    default:
                                        break;
                                }

                            }
                            catch (Exception)
                            {

                                Console.WriteLine(textlog.ErrorText(ErrorCode.WrongInputType));
                                Console.ReadKey();
                                textlog.ClearConsole();
                            }


                        } while (pickCard == false);



                    }
                    else if (playerManager.Players[i] is Ai && playerManager.Players[i].Hand.Count > 0)
                    {
                        if (playerManager.Players[i].Hand.Count == 0)
                        {
                            playerManager.Players.Remove(playerManager.Players[i]);
                        }
                        else
                        {
                            Console.Clear();
                            string aiText = $"{playerManager.Players[i].Name} {playerManager.Players[i].Pair()}\n";
                            
                            if (aiText.Contains("paired"))
                            {
                                Console.WriteLine(aiText);
                                Console.WriteLine($"ending {playerManager.Players[i].Name} turn");
                            }
                            else
                            {
                            Console.WriteLine(playerManager.Players[i].AddCard(playerManager.Players[i - 1].GiveCard()));

                            }
                            Console.ReadKey();

                        }
                    }

                    if (playerManager.Players[i].Hand.Count == 0)
                    {
                        if (playerManager.Players[i].Name == textlog.PlayerName)
                        {
                            Console.WriteLine($"{playerManager.Players[i].Name} you won, exiting the game!");

                        }
                        Console.WriteLine($"{playerManager.Players[i].Name} is no longer playing {playerManager.Players[i].Name}");
                        playerManager.Players.Remove(playerManager.Players[i]);

                    }
                    if (playerManager.Players.Count <= 1 && playerManager.Players[0].Name != textlog.PlayerName)
                    {

                        Console.WriteLine("Game has ended");
                        Console.ReadKey();
                        gamerunning = false;
                    }
                }


            }
            while (gamerunning == true);

            Console.ReadKey();
        }
    }
}
