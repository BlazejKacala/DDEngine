using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDEngine.data.proficiencies;

namespace DDEngine.data.items.wearable.armors
{
    public enum HeavyArmorSubtype
    {
        Ringmail, Chainmail, Splint, Plate
    }

    class HeavyArmor : Armor
    {
        public HeavyArmorSubtype HeavyArmorSubtype { get; set; }
        public override List<Proficiency> Requirements => new List<Proficiency>() { Proficiency.UseHeavyArmor };
    }
}
