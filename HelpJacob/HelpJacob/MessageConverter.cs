using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    class MessageConverter
    {

        public MessageConverter()
        {

        }

        /// <summary>
        /// Converting it to html
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public string ConvertBodyToHTML(Message m)
        {
            if (m.Html)
            {
                
                return "Already html";
            }
            else
            {

                m.Body = "" + m.Body + "";
                return "Converted to html";
            }
            
        }
    }
}
