using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Banker banker = new Banker("John den lange");
            Human human = new Human("johh den korte");
            human.Card = banker.CreateCard(CardType.Mastercard);

            Console.WriteLine(human.Card.AccountNumber);
      

            human.Card.Money = 2000;

            Console.WriteLine(human.Card.Money);
            human.UseMoney(119);
            Console.WriteLine(human.Card.Money);
            Console.WriteLine();

        }
    }
}
