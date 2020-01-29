using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineTask
{
    class Filter
    {
        private int maxAmount;
        private int currentAmount;
   

        //Properties
        public int MaxAmount
        {
            get { return maxAmount; }
            private set { maxAmount = value; }
        }
        public int CurrentAmount
        {
            get { return currentAmount; }
            set
            {
                if (value > currentAmount)
                {
                    currentAmount = maxAmount;
                }
                else
                {
                    currentAmount = value;
                }
            }
        }

     
        //Constructor
        public Filter(int maxAmountCoffe)
        {
            MaxAmount = maxAmountCoffe;
        }
    }
}
