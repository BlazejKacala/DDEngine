using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.skills
{
    public class Skills
    {
        private Dictionary<SkillType, int> skills = new Dictionary<SkillType, int>();

        public int GetValue(SkillType skillType)
        {
            return skills[skillType];
        }

        public void setValue(SkillType skillType, int value)
        {
            skills[skillType] = value;
        }



    }
}
