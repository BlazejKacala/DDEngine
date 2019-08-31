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
            ClassLvls = new List<ClassLvl>();
        }

        public List<ClassLvl> ClassLvls { get => classLvls; set => classLvls = value; }

        public int GetLvl()
        {
            return ClassLvls.Sum(it => it.Lvls);
        }
        
    }

    public class ClassLvl
    {

        public int Lvls { get; set; }
        public ClassType CharacterClass { get; set; }

        public ClassLvl(int lvls, ClassType classType) {
            this.Lvls = lvls;
            this.CharacterClass = classType;
        }
    }
}
