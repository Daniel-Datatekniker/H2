using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTaskReal
{
    class MessageController
    {
        ICommunication c;
        Message m;
        public MessageController(ICommunication c, Message m)
        {
            this.c = c;
            this.m = m;
        }
        public void SendMessage()
        {
            c.DeliverMessage(m);
        }
    }
}
