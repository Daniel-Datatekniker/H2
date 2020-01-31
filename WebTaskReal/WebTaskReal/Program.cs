using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTaskReal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* I could had made Link as string you need to put through the handler
             * but i was thinking about future updates, maybe link could 
             * 
             */
            while (true)
            {
                Console.Clear();
                string url = "";
                try
                {
                    Console.WriteLine("Press [1] to request website\nPress [2] to read a file");
                    ConsoleKeyInfo input = Console.ReadKey();
                    Console.Clear();
                    switch (input.KeyChar)
                    {
                        case '1':
                            Console.Write("Input url link : ");
                            url = Console.ReadLine();
                            Link link = new Link($"{url}");
                            WebsiteRequest websiteRequest = new WebsiteRequest();
                            RequestHandler handler = new RequestHandler(websiteRequest, link);
                            Console.Clear();
                            Console.WriteLine(handler.Request());
                            break;
                        case '2':
                            Console.Write("Input url path : ");
                            url = Console.ReadLine();
                            link = new Link($"{url}");
                            FileRequest file = new FileRequest();
                            handler = new RequestHandler(file, link);
                            Console.Clear();
                            Console.WriteLine(handler.Request());
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }
                catch (Exception e) 
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }

                Console.ReadKey();
            }
           

        



        }
    }
}
