using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data
{

    public enum Ability { Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma }

    public class Abilities
    {

        private Dictionary<Ability, int> abilitiesDictionary = new Dictionary<Ability, int>();

        public int Strength
        {
            set
            {
                abilitiesDictionary[Ability.Strength] = value;
            }

            get
            {
                return abilitiesDictionary[Ability.Strength];
            }
        }

        public int Dexterity
        {
            set
            {
                abilitiesDictionary[Ability.Dexterity] = value;
            }

            get
            {
                return abilitiesDictionary[Ability.Dexterity];
            }
        }

        public int Constitution
        {
            set
            {
                abilitiesDictionary[Ability.Constitution] = value;
            }

            get
            {
                return abilitiesDictionary[Ability.Constitution];
            }
        }

        public int Intelligence
        {
            set
            {
                abilitiesDictionary[Ability.Intelligence] = value;
            }

            get
            {
                return abilitiesDictionary[Ability.Intelligence];
            }
        }

        public int Wisdom
        {
            set
            {
                abilitiesDictionary[Ability.Wisdom] = value;
            }

            get
            {
                return abilitiesDictionary[Ability.Wisdom];
            }
        }

        public int Charisma
        {
            set
            {
                abilitiesDictionary[Ability.Charisma] = value;
            }

            get
            {
                return abilitiesDictionary[Ability.Charisma];
            }
        }

    }
}
