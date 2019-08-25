using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDEngine.data.proficiencies;

namespace DDEngine.data.items.wearable
{
    class Weapon : Item, IUsable
    {
        public List<Proficiency> Requirements => throw new NotImplementedException();
    }
}
