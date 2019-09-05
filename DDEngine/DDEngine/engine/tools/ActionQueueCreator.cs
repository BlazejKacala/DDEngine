using DDEngine.engine.combat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine.tools
{
    public static class ActionQueueCreator
    {
        public static List<Player> MakeQueue(List<Player> party, List<Player> opponnets, AbilityChecker abilityChecker)
        {
            List<Tuple<Player, int>> rolls = MakePlayerRollsTuples(party, opponnets, abilityChecker);
            rolls.Sort((p, q) => p.Item2.CompareTo(q.Item2));
            return rolls.Select(x => x.Item1).ToList();
        }

        private static List<Tuple<Player, int>> MakePlayerRollsTuples(List<Player> party, List<Player> opponnets, AbilityChecker abilityChecker)
        {
            List<Tuple<Player, int>> rolls = new List<Tuple<Player, int>>();
            if (party != null)
            {
                foreach (Player player in party)
                {
                    rolls.Add(Tuple.Create(player, abilityChecker.MakeAbilityCheck(player.Character, data.Ability.Dexterity)));
                }
            }
            if (opponnets != null)
            {
                foreach (Player player in opponnets)
                {
                    rolls.Add(Tuple.Create(player, abilityChecker.MakeAbilityCheck(player.Character, data.Ability.Dexterity)));
                }
            }

            return rolls;
        }
    }
}
