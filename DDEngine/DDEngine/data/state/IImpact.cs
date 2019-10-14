using System;
namespace DDEngine.data.state.impacts
{
    public interface IImpact
    {
        ImpactType GetType();
    }

    public enum ImpactType { HitChance, ArmorClassBonus }
}
