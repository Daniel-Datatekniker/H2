using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineTask
{
    class WaterTank
    {
        private int currentWater;
        private int maxWater;

        public int MaxWater
        {
            get { return maxWater; }
            private set
            {
                maxWater = value;
            }
        }


        public int CurrentWater
        {
            get { return currentWater; }
            set
            {
                if (value > MaxWater)
                {
                    currentWater = maxWater;
                }
                else
                {
                    currentWater = value;
                }
            }
        }


        public WaterTank(int WaterLimit)
        {
            MaxWater = WaterLimit;
        }


    }
}
