using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    class Knight : IBasic, IMelee, IShield
    {
        public string Bash()
        {
            return "i bashed that bastard";
        }

        public string Cleave()
        {
            return "i used cleave attack";
        }

        public string Die()
        {
            return "i died";
        }

        public string Fight()
        {
            return "i fight";
        }

        public string Heal()
        {
            return "I heal";
        }

        public string RaiseShield()
        {
            return "I raised my shield";
        }

        public string ShieldGlare()
        {
            return "i used shield glare";
        }

        public string Slash()
        {
            return "i slashed";
        }
    }
}
