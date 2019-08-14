using DDEngine.data.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data
{
    public class Character
    {

        public string Name { get; set; }

        public Alignment alignment { get; set; }

        public CharacterClassWrapper characterClass { get; set; }

        public Abilities Abilities { get; set; }

        public int XP { get; set; }

        public int MaxHP { get; set; }

        public int ArmorClass { get; set; }

        public int Initiative { get; set; }

        public int Speed { get; set; }

    }
    
}
