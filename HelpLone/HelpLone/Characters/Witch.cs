using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    class Witch : IBasic, IShield, ITeleport
    {
        public string Die()
        {
            return "Im dying";
        }

        public string Fight()
        {
            return "Im fighting";
        }

        public string Heal()
        {
            return "im healing";
        }

        public string RaiseShield()
        {
            return "i have raised my shield";
        }

        public string ShieldGlare()
        {
            return "my shield glare";
        }

        public string Teleport(int x, int y)
        {
            return $"im teleport to x={x}, y={y}";
        }
    }
}
