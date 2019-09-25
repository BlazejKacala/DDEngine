using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDEngine.data.proficiencies;

namespace DDEngine.data.items.wearable
{
    public enum ArmorType
    {
        Light, Medium, Heavy
    }

    public abstract class Armor : Item, IUsable
    {
        public ArmorType ArmorType { get; set; }
        public int ArmorClass { get; set; }
        public int DexterityBonus { get; set; }
        public int AcBonus { get; set; }
        public bool StealthDisadvantafe { get; set; }
        public abstract List<Proficiency> Requirements { get; }
    }
}
