using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    class SmtpSender : IMessageSender
    {
        public SmtpSender()
        {

        }
        /// <summary>
        /// sending smtp message
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public virtual string SendMessage(Message m)
        {
            return "Smtp sent";
        }
        /// <summary>
        /// Sending message to everyone
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public virtual string SendToAll(Message m)
        {
            return "Smtp sent";
        }
    }
}
