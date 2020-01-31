using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Maestro : Card
    {
        public Maestro()
        {

        }
        public Maestro(string humanName, int[] cardnumb, int[] accountNumb) : base(humanName, cardnumb, accountNumb)
        {
            
            ExperiationDate = DateTime.UtcNow.AddYears(5).AddMonths(8);
            
        }
    }
}
