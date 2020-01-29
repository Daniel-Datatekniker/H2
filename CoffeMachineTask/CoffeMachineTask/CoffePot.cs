using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineTask
{
    class CoffePot
    {
        //Attributes
        private int maxCoffe;
        private int currentCoffe;

        //Properties
        public int MaxCoffe
        {
            get { return maxCoffe; }
            private set { maxCoffe = value; }
        }
        public int CurrentCoffe
        {
            get { return currentCoffe; }
            set { currentCoffe = value; }
        }
        //Constructor
        public CoffePot(int maximumCoffe)
        {
            MaxCoffe = maximumCoffe;
        }

    }
}
