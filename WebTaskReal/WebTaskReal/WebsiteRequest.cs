using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebTaskReal
{
    class WebsiteRequest : IRequest
    {
        //Attribute
        private string html;
        private WebRequest webRequest;
        private WebResponse WebResponse;
        //Properties

        //Constructor
        public WebsiteRequest()
        {
          
            
        }
            //Methods
        public string Request(Link link)
        {
            webRequest = WebRequest.Create(link.Path);
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            Response();

            return $"{html}";
        }

        private void Response()
        {
            WebResponse = webRequest.GetResponse();
            Stream();
        }

        private void Stream()
        {
            using (Stream dataStream = WebResponse.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                html += responseFromServer;
            }
            WebResponse.Close();
        }

    }
}
