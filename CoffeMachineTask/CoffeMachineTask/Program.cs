using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeMachineTask
{
    class Program
    {
        static void Main(string[] args)
        {

            CoffeMachine coffeMachine = new CoffeMachine("model", new CoffePot(100));
            Human human = new Human("Camilla");


            while (true)
            {
                while (coffeMachine.OnOff == false)
                {
                    Console.Clear();
                    Console.WriteLine("Press [1] to add filter\nPress [2] to add water\nPress [3] to brew coffe\nPress[4] to shutdown coffe machine");
                    try
                    {
                        ConsoleKeyInfo input = Console.ReadKey();
                        Console.Clear();
                        switch (input.KeyChar)
                        {
                            case '1':
                                Console.WriteLine(human.AddFilter(coffeMachine));
                                break;
                            case '2':
                                Console.WriteLine(human.AddWater(coffeMachine));
                                break;
                            case '3':
                                if (coffeMachine.Filter != null)
                                {
                                    Console.WriteLine("Started brewing");
                                    Console.WriteLine(human.StartCoffeMachine(coffeMachine));
                                }
                                else
                                {
                                    Console.WriteLine("doh you forgot filter");
                                }
                                break;
                            case '4':
                                if (coffeMachine.OnOff == false)
                                {
                                    Console.WriteLine("Coffe is already off");
                                }
                                else
                                {
                                    Console.WriteLine(human.StopCoffeMachine(coffeMachine));
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception e)
                    {

                        Debug.WriteLine(e.Message);
                        Console.WriteLine("Wrong input");
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }


            }



        }
    }
}
