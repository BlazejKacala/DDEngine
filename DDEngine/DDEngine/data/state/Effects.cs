using System.Collections.Generic;
using DDEngine.data.state.impacts;

namespace DDEngine.data.state
{

    public abstract class Effect
    {
        public long RemainingTime { get; set; }

        public Character Caster { get; set; }

        public abstract List<IImpact> Impacts { get; }
    }

    public class Effects
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

        public List<Effect> GetEffectsByImpactType(ImpactType impactTypeToFind)
        {
            return effects.FindAll((effect) => effect.Impacts.Exists((impactType) => impactType.GetType() == impactTypeToFind));
        }

    }

}
