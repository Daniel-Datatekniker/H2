using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    class Wizard : IBasic, ITeleport, ISpell
    {
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
            return "i heal";
        }

        public string Teleport(int x, int y)
        {
            return $"i teleported to x={x}, y={y}";
        }

        public string ThrowFrostNova()
        {
            return "i threw a frost nova";
        }

        public string ThrowMagicMissisle()
        {
            return "i casted a magic missile";
        }
    }
}
