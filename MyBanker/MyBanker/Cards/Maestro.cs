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
            Prefix = new List<int>() { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
            ExperiationDate = DateTime.UtcNow.AddYears(5).AddMonths(8);
            
        }
    }
}
