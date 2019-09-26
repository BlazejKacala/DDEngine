using System;
namespace DDEngine.data.state.impacts
{
    public class ChangeHitChanceImpact : IImpact
    {
        public float HitChanceFactor { set; get; }

        public ChangeHitChanceImpact(float hitChanceFactor)
        {
            HitChanceFactor = hitChanceFactor;
        }

        ImpactType IImpact.GetType()
        {
            return ImpactType.HitChance;
        }
    }
}
