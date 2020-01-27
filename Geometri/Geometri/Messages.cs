using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Messages
    {
        private string returnMessage;
        public Messages()
        {

        }

        public string Message(Boxes BoxType)
        {
            
            switch (BoxType)
            {
                case Boxes.Square:
                    returnMessage = $"The perimeter of the {BoxType} = ";
                    break;

                default:

                    break;
            }
            return returnMessage;
        }

    }
}
