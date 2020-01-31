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
            //Message m = new Message();
            //EmailTransport emailTransport = new EmailTransport();


            //MessageController messageController = new MessageController(emailTransport, m);

            //messageController.SendMessage();

            Link link = new Link("http://google.com");
            WebsiteRequest websiteRequest = new WebsiteRequest();

            RequestHandler handler = new RequestHandler(websiteRequest, link);

            Console.WriteLine(handler.Request());

        }
    }
}
