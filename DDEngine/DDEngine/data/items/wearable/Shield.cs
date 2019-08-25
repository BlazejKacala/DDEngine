using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDEngine.data.proficiencies;

namespace DDEngine.data.items.wearable
{
    class Shield : Item, IUsable
    {
        public int AcBonus { get; set; }

        public List<Proficiency> Requirements => new List<Proficiency>() { Proficiency.UseShield };
    }
}
