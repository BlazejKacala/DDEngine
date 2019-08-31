using DDEngine.engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.items.wearable.weapons
{
    public class WeaponDamage
    { 

        public WeaponDamage(int dicesAmount, int diceType, DamageType damageType)
        {
            DicesAmount = dicesAmount;
            DiceType = diceType;
            DamageType = damageType;
        }
        public int DicesAmount { get; set; }
        public int DiceType { get; set; }
        public DamageType DamageType { get; set; }

    }
}
