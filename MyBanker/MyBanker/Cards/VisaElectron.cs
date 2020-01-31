using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaElectron : Card
    {
        //Attributes
        private double maxUsage;

        //Properties
        public double MaxUsage
        {
            get { return maxUsage; }
            set { maxUsage = value; }
        }

        //Constructors

        public VisaElectron()
        {
            
        }


        public VisaElectron(string humanName, int[] cardnumb, int[] accountNumb) : base(humanName, cardnumb, accountNumb)
        {
            Prefix = new List<int>() { 4026, 417500, 4508, 4844, 4913, 4917 };
            ExperiationDate = DateTime.UtcNow.AddYears(5);
        }


    }
}
