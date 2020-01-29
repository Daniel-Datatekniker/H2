using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineTask
{
    class Human
    {
        //Attribute
        private string name;

        //Properties
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        //Constructor
        public Human(string humanName)
        {
            Name = humanName;
        }

        //Methods
        public string AddWater(CoffeMachine cm)
        {
            cm.Tank.CurrentWater = cm.Tank.MaxWater;
            return $"tank is full";
        }

        public string AddFilter(CoffeMachine cm)
        {
            if (cm.Filter != null)
            {
                string returnText = $"{RemoveFilter(cm)} and I added a new filter"; 
                cm.Filter = new Filter(100);
                return returnText;
            }
            else
            {
                cm.Filter = new Filter(100);
                return "i added a filter";
            }
        }

        public string RemoveFilter(CoffeMachine cm)
        {
            cm.Filter = null;
            return "i removed the old filter";
        }

        public string StartCoffeMachine(CoffeMachine cm)
        {
            return cm.Start();
        }
        public string StopCoffeMachine(CoffeMachine cm)
        {
            return cm.Stop();
        }
    }
}
