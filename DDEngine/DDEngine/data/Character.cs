﻿using DDEngine.data.classes;
using DDEngine.data.items;
using DDEngine.data.properties;
using DDEngine.data.skills;
using DDEngine.data.state;

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

        public Inventory Inventory { get; set; }

        public int XP { get; set; }

        public int MaxHP { get; set; }

        public int Speed { get; set; }

    }
    
}
