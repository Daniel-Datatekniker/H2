using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace WebTaskReal
{
    class FileRequest : IRequest
    {
        //Attribute
        private string fileText;
        //Properties
    

        //Constructor
        public FileRequest()
        {
            
        }

        //Methods
        public string Request(Link link)
        {
            FileStream(link);
            return fileText;
        }

        private void FileStream(Link link)
        {
            try
            {
                using (FileStream Fs = File.OpenRead(link.Path))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (Fs.Read(b, 0, b.Length) > 0)
                    {
                        fileText += temp.GetString(b);
                    }
                }
            }
            catch (Exception e)
            {

                fileText =  e.Message;
            }

        }

    }
}
