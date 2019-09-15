using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDEngine.data.items.wearable.weapons;
using DDEngine.data.proficiencies;

namespace DDEngine.data.items.wearable
{
    public abstract class Weapon : Item, IUsable
    {
        public abstract WeaponDamage GetBaseWeaponDamage();

        public List<WeaponDamage> AdditionalDamage { get; set; }

        public abstract List<Proficiency> Requirements { get; }

        public abstract WeaponProperties WeaponProperties { get; }

    }
}
