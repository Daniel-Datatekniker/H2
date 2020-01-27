using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages messages = new Messages();
            Square square = new Square(20);

            Console.WriteLine($"{messages.Message(square.Type)} {square.A}");


            Console.ReadLine();
        }
    }
}
