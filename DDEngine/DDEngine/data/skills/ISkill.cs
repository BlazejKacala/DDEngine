using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.skills
{

    public enum SkillType {
        Athletics,
        Acrobatics,
        SleightOfHand,
        Stealth,
        AnimalHandling,
        Insight,
        Medicine,
        Perception,
        Survivial,
        Arcana,
        History,
        Investigation,
        Nature,
        Religion,
        Deception,
        Intimidate,
        Performance,
        Persuasion
    }

    interface ISkill
    {

        Ability GetAbilityScore();
    }
}
