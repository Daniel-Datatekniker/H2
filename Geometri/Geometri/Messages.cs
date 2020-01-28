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

        public string Message(Calculation BoxType)
        {
            
            switch (BoxType)
            {
                case Calculation.Perimeter:
                    returnMessage = $"The perimeter = ";
                    break;

                case Calculation.Area:
                    returnMessage = $"The area = ";
                    break;
                default:

                    break;
            }
            return returnMessage;
        }

    }
}
