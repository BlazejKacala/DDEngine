using DDEngine.data;
using DDEngine.engine.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine.combat
{
    public class SupriseChecker
    {
        private readonly AbilityChecker abilityChecker;

        public SupriseChecker(AbilityChecker abilityChecker)
        {
            this.abilityChecker = abilityChecker;
        }

        public bool MakeSupriseCheck(List<Character> party, List<Character> opponents)
        {
            foreach(Character player in party)
            {
                foreach(Character opponent in opponents)
                {
                    if(!abilityChecker.MakeContestCheck(player, opponent, data.skills.SkillType.Stealth, data.skills.SkillType.Perception))
                    {
                        Console.WriteLine("Suprise failed");
                        return false;
                    }
                }

            }
            return true;
        }

    }
}
