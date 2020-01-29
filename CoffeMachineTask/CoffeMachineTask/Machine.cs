using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeMachineTask
{
    public abstract class Machine
    {
        //Attributes
        private string modelNumber;
        private bool onOff = false;



        //Properties
        public string ModelNumber
        {
            get { return modelNumber; }
            private set { modelNumber = value; }
        }

        public bool OnOff
        {
            get { return onOff; }
            set { onOff = value; }
        }

        //Constructor
        public Machine(string model)
        {
            ModelNumber = model;
        }

        //Methods
        public virtual string Start()
        {
            onOff = true;
            return "Started";
        }

        public virtual string Stop()
        {
            onOff = false;
            return "Stopped";
        }
    }
}
