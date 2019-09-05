using DDEngine.data;
using DDEngine.data.skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine.tables
{
    static class AbilityScore
    {
        private static readonly Dictionary<int, int> basicAbilityScore = new Dictionary<int, int>() {

            { 1, -5 },
            { 2, -4},
            { 3, -4},
            { 4, -3},
            { 5, -3},
            { 6, -2},
            { 7, -2},
            { 8, -1},
            { 9, -1},
            { 10, 0},
            { 11, 0},
            { 12, 1},
            { 13, 1},
            { 14, 2},
            { 15, 2},
            { 16, 3},
            { 17, 3},
            { 18, 4},
            { 19, 5},
            { 20, 5},
            { 21, 5},
            { 22, 6},
            { 23, 6},
            { 24, 7},
            { 25, 7},
            { 26, 8},
            { 27, 8},
            { 28, 9},
            { 29, 9},
            { 30, 10},

        };

        public static int CalculateAbilityScore(Character character, SkillType skillType)
        {
            Ability ability = GetAbilityAssociatedWithSkillType(skillType);
            return basicAbilityScore[character.Abilities.GetValue(ability)];
        }

        public static int CalculateAbilityScore(Character character, Ability ability)
        {
            return basicAbilityScore[character.Abilities.GetValue(ability)];
        }

        private static Ability GetAbilityAssociatedWithSkillType(SkillType skillType)
        {
            switch (skillType)
            {
                case SkillType.Athletics:
                    return Ability.Strength;
                case SkillType.Acrobatics:
                case SkillType.SleightOfHand:
                case SkillType.Stealth:
                    return Ability.Dexterity;
                case SkillType.AnimalHandling:
                case SkillType.Insight:
                case SkillType.Medicine:
                case SkillType.Perception:
                case SkillType.Survivial:
                    return Ability.Wisdom;
                case SkillType.Arcana:
                case SkillType.History:
                case SkillType.Investigation:
                case SkillType.Nature:
                case SkillType.Religion:
                    return Ability.Intelligence;
                case SkillType.Deception:
                case SkillType.Intimidate:
                case SkillType.Performance:
                case SkillType.Persuasion:
                    return Ability.Charisma;
                default:
                    throw new InvalidOperationException("Unknown skill type");
            }
        }
    }
}
