using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    class Babarian : IBasic, IMelee
    {
        public string Bash()
        {
            return "i bashed him";
        }

        public string Cleave()
        {
            return "i use a cleave attack";
        }

        public string Die()
        {
            return "i died";
        }

        public string Fight()
        {
            return "im fighting";
        }

        public string Heal()
        {
            return "im healing";
        }

        public string Slash()
        {
            return "i slashed him";
        }
    }
}
