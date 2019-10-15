using System;
using DDEngine.data;
using DDEngine.data.items.wearable;
using DDEngine.engine.tables;

namespace DDEngine.engine.tools
{
    public class AcCalculator
    {
        public int CalculateAc(Character player, Character target)
        {
            Armor targetArmor = player.Inventory.Armor;
            int dexterityScore = AbilityScore.CalculateAbilityScore(player, Ability.Dexterity);

            int resultAc = targetArmor.ArmorClass;
            resultAc += Math.Min(dexterityScore, targetArmor.DexterityBonus);
            resultAc += targetArmor.AcBonus;

            return resultAc;

        }
    }
}
