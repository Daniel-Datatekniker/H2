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
            Maestro maestro = new Maestro("", new int[12], new int [123]);


            Console.WriteLine(maestro.CardNumber.Length);
            Console.WriteLine(maestro.ExperiationDate.ToString("MM/yy"));
       
            
        }
    }
}
