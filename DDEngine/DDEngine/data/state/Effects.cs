using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.state
{

    public abstract class Effect
    {
        public long RemainingTime { get; set; }

        public Character Caster { get; set; }
    }

    class Effects
    {
        private List<Effect> effects;

        public List<Effect> GetEffects()
        {
            return effects;
        }

        public void SetEffects(List<Effect> value)
        {
            effects = value;
        }

    }

}
