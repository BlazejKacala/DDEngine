using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine
{
    public class Combat
    {
        private Battlefield battlefield;

        public void StartNewCombat(Battlefield battlefield, bool isPartyStealthy, bool areOpponentsStealthy)
        {
            if (battlefield is null)
            {
                throw new ArgumentNullException(nameof(battlefield));
            }
            this.battlefield = battlefield;




        }
    }
}
