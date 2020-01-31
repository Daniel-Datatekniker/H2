using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Debit : Card
    {
        public Debit()
        {
            
        }
        public Debit(string humanName, int[] cardnumb, int[] accountNumb) : base(humanName, cardnumb, accountNumb)
        {

            ExperiationDate = DateTime.UtcNow.AddYears(50);
        }
    }
}
