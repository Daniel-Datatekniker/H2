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

                    Console.WriteLine("Press [1] to add coffe capsule\nPress [2] to add tea capsule\nPress [3] to add Express capsule\nPress [4] to add water\nPress [5] to start brewing\nPress [6] to shutdown coffe machine");
                    try
                    {
                        ConsoleKeyInfo input = Console.ReadKey();
                        Console.Clear();
                        switch (input.KeyChar)
                        {
                            case '1':
                                Console.WriteLine(human.AddCapsule(coffeMachine, CapsuleType.Coffe));
                                break;
                            case '2':
                                Console.WriteLine(human.AddCapsule(coffeMachine, CapsuleType.Tea));
                                break;
                            case '3':
                                Console.WriteLine(human.AddCapsule(coffeMachine, CapsuleType.Expresso));
                                break;
                            case '4':
                                Console.WriteLine(human.AddWater(coffeMachine));
                                break;
                            case '5':
                                if (coffeMachine.Capsule != null)
                                {
                                    Console.WriteLine("Started brewing");
                                    Console.WriteLine(human.StartCoffeMachine(coffeMachine));
                                }
                                else
                                {
                                    Console.WriteLine("doh you forgot capsule");
                                }
                                break;
                            case '6':
                                if (coffeMachine.OnOff == false)
                                {
                                    Console.WriteLine("Coffe Machine is already off");
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
