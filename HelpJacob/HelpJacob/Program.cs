using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("karl", "johannes", "lud", "sor", "doc", true);
            
            MessageConverter converter = new MessageConverter();
            VMessageSender vMessage = new VMessageSender();
            SmtpSender smtpSend = new SmtpSender();


            Console.WriteLine(converter.ConvertBodyToHTML(message));

            Console.WriteLine(vMessage.SendMessage(message));
            Console.WriteLine(vMessage.SendToAll(message));
            Console.WriteLine(smtpSend.SendMessage(message));
            Console.WriteLine(smtpSend.SendToAll(message));
   
        }
    }
}
