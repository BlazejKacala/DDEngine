using DDEngine.data.items.wearable;
using DDEngine.data.items.wearable.weapons.ammunition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.items
{
    public class Inventory
    {
        public Armor Armor { set; get; }

        public Weapon RightHand { set; get; }

        public Item LeftHand { set; get; }

        public Ammunition Quiver { set; get; }

        public List<Item> Backpack { set; get; }
    }
}
