using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineTask
{
    class Capsule
    {
        private CapsuleType type;

        public CapsuleType Type
        {
            get { return type; }
            set { type = value; }
        }



        //Constructor
        public Capsule(CapsuleType capsuleType)
        {
            Type = capsuleType;
        }
    }
}
