using System;
using System.Collections.Generic;
using DDEngine.data;
using DDEngine.data.items.wearable;
using DDEngine.data.state;
using DDEngine.data.state.impacts;
using DDEngine.engine.tables;

namespace DDEngine.engine.tools
{
    public class AcCalculator
    {
        public int CalculateAc(Character player, Character target)
        {
            int ac = CalculateBaseAc(player);
            ac += ApplyBonuses(player);
            return ac;
        }

        private int CalculateBaseAc(Character player)
        {
            Armor targetArmor = player.Inventory.Armor;
            int dexterityScore = AbilityScore.CalculateAbilityScore(player, Ability.Dexterity);

            int resultAc = targetArmor.ArmorClass;
            resultAc += Math.Min(dexterityScore, targetArmor.DexterityBonus);
            resultAc += targetArmor.AcBonus;
            return resultAc;
        }

        private int ApplyBonuses(Character player)
        {
            int acBonus = 0;
            List<Effect> acEffects = player.State.Effects.GetEffectsByImpactType(ImpactType.ArmorClassBonus);
            foreach (Effect effect in acEffects)
            {
                foreach (IImpact impact in effect.Impacts)
                {
                    if (impact.GetType() == ImpactType.ArmorClassBonus)
                    {
                        acBonus += ((ArmorClassBonusImpact)impact).ArmorClassBonus;
                    }
                }
            }
            return acBonus;
        }
    }
}
