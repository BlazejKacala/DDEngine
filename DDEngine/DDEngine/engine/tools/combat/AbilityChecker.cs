using DDEngine.data;
using DDEngine.data.skills;
using DDEngine.engine.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine.combat
{
    public class AbilityChecker
    {
        private IDice d20;

        public AbilityChecker(IDice d20)
        {
            this.d20 = d20;
        }

        public int MakeAbilityCheck(Character character, Ability ability)
        {
            return d20.Roll() + AbilityScore.CalculateAbilityScore(character, ability);
        }


        public bool MakeAbilityCheck(int DC, Character character, SkillType skillType)
        {
            return MakeAbilityCheck(DC, character, skillType, false);
        }

        public bool MakeAbilityCheck(int DC, Character character, SkillType skillType, bool hasAdvantage)
        {
            int roll = ApplyBonus(d20.Roll(), character, skillType);
            if (hasAdvantage)
            {
                roll = Math.Max(roll, ApplyBonus(d20.Roll(), character, skillType));
            }
            return roll >= DC;
        }

        public bool MakePassiveCheck(Character character, SkillType skillType, bool hasAdvantage)
        {
            return MakeAbilityCheck(10, character, skillType, hasAdvantage);
        }

        public bool MakeContestCheck(Character c1, Character c2, SkillType s1, SkillType s2)
        {
            return ApplyBonus(d20.Roll(), c1, s1) > ApplyBonus(d20.Roll(), c2, s2);
        }

        private int ApplyBonus(int roll, Character character, SkillType skillType)
        {
            return roll + AbilityScore.CalculateAbilityScore(character, skillType);
        }

    }

}
