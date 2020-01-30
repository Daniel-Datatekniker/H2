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

        public string AddCapsule(CoffeMachine cm, CapsuleType capsule)
        {
            if (cm.Capsule != null)
            {
                string returnText = $"{RemoveCapsule(cm)} capsule and I added a {capsule.ToString()} capsule"; 
                cm.Capsule = new Capsule(capsule);
                return returnText;
            }
            else
            {
                cm.Capsule = new Capsule(capsule);
                return $"i added a {capsule.ToString()} capsule";
            }
        }

        public string RemoveCapsule(CoffeMachine cm)
        {
            string oldCap = cm.Capsule.Type.ToString();
            cm.Capsule = null;
            return $"i removed the old {oldCap}";
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
