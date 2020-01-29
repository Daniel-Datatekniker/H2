using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    class VMessageSender : IMessageSender
    {
        public VMessageSender()
        {

        }

        /// <summary>
        /// Sending Vmessage 
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public virtual string SendMessage(Message m)
        {
            return "VMessage sent";
        }

        /// <summary>
        /// Sending Vmessage to all
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public virtual string SendToAll(Message m)
        {
            return "VMessage sent to all";
        }
    }
}
