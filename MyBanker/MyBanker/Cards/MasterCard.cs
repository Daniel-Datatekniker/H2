using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class MasterCard : Card
    {
        public MasterCard()
        {

        }
        public MasterCard(string humanName, int[] cardnumb, int[] accountNumb) : base(humanName, cardnumb, accountNumb)
        {
            
                ExperiationDate = DateTime.UtcNow.AddYears(5);
        }
    }
}
