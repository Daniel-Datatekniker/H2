using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    class Message
    {
        //Attributes
        string to, from, body, subject, cc;
        bool html;

        //Properties
        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc { get => cc; set => cc = value; }
        public bool Html { get => html; set => html = value;}

        //Constructor
        public Message(string to, string from, string body, string subject, string cc, bool isHtml)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
            this.html = isHtml;
        }


      
       

 



    }
}
