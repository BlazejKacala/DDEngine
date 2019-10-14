using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.items.wearable.weapons.ammunition
{

    public enum AmmunitionType
    {
        Arrow, Bolt, Bullet
    }

    public class Ammunition
    {
        public WeaponDamage weapon;

        public AmmunitionType Type { set; get; }

        public int MaxQuanitity { set; get; } 

        public int CurrentQuanitity
        {
            set
            {
                if(value > MaxQuanitity)
                {
                    throw new InvalidOperationException("Value cannot be larger then " + MaxQuanitity);
                }
                if (value < 0)
                {
                    throw new InvalidOperationException("Value cannot be smaller then 0");
                }
                CurrentQuanitity = value;
            }

            get
            {
                return CurrentQuanitity;
            }

        }

        public void Fire()
        {
            if(CurrentQuanitity > 0)
            {
                CurrentQuanitity--;
            } else
            {
                throw new InvalidOperationException("No ammo left");
            }
        }

    }
}
