using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine.combat
{
    class SupriseChecker
    {
        private IDice dice20;

        public SupriseChecker(IDice dice)
        {
            if (dice.D != 20)
            {
                throw new InvalidOperationException("SupriseChecker requires D20 dice, got " + dice.D);
            }
            this.dice20 = dice;
        }

        public bool MakeSupriseCheck(List<Player> party, List<Player> opponents)
        {
            throw new NotImplementedException();
        }

    }
}
