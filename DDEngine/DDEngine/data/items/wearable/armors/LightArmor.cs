using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDEngine.data.proficiencies;

namespace DDEngine.data.items.wearable.armors
{
    public enum LightArmorSubtype
    {
        Padded, Leather, StuddedLeather
    }

    class LightArmor : Armor
    {
        public LightArmorSubtype LightArmorSubtype { get; set; }
        public override List<Proficiency> Requirements => new List<Proficiency>() { Proficiency.UseLightArmor };
    }
}
