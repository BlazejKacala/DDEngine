using System.Collections.Generic;
using DDEngine.data.proficiencies;

namespace DDEngine.data.items.wearable.armors
{
    public enum MediumArmorSubtype
    {
        Hide, Chainshirt, Scalemail, Breastplate, Halfplate,
    }

    public class MediumArmor : Armor
    {
        public MediumArmorSubtype MediumArmorSubtype { get; set; }
        public override List<Proficiency> Requirements => new List<Proficiency>() { Proficiency.UseMediumArmor };
    }
}
