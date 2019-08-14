using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.classes
{
    public class CharacterClassWrapper
    {
        private List<ClassLvl> classLvls;
 
        CharacterClassWrapper()
        {
            classLvls = new List<ClassLvl>();
        }
        
    }

    public class ClassLvl
    {

        public int lvls { get; set; }
        public ClassType characterClass { get; set; }

        public ClassLvl(int lvls, ClassType classType) {
            this.lvls = lvls;
            this.characterClass = classType;
        }
    }
}
