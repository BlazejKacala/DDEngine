using DDEngine.data.classes;
using DDEngine.data.properties;
using DDEngine.data.skills;
using DDEngine.data.state;
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

        public Race Race { get; set; }

        public Subrace Subrace { get; set; }

        public Alignment Alignment { get; set; }

        public CharacterClassWrapper CharacterClass { get; set; }

        public Abilities Abilities { get; set; }

        public Skills Skills { get; set; }

        public State State { get; set; }

        public int XP { get; set; }

        public int MaxHP { get; set; }

        public int Speed { get; set; }

    }
    
}
