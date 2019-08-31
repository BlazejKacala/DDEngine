using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.skills
{
    public class Stealth : ISkill
    {
        public Ability GetAbilityScore()
        {
            return Ability.Dexterity;
        }
    }
}
