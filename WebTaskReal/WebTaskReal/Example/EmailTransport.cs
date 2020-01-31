using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTaskReal
{
    class EmailTransport : ICommunication
    {
        public void DeliverMessage(Message m)
        {
            Console.WriteLine(m.text);
        }
        //stmt

    }
}
