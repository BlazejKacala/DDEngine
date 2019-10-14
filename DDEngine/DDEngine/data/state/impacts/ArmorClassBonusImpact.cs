using System;
namespace DDEngine.data.state.impacts
{
    public class ArmorClassBonusImpact : IImpact
    {
        public int ArmorClassBonus { set; get; }

        public ArmorClassBonusImpact(int armorClassBonus)
        {
            ArmorClassBonus = armorClassBonus;
        }

        ImpactType IImpact.GetType()
        {
            return ImpactType.ArmorClassBonus;
        }
    }
}
