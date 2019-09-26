using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDEngine.data.state.impacts;

namespace DDEngine.data.state.effects
{
    public class Blur : Effect
    {
        public override List<IImpact> Impacts { get => new List<IImpact> { ChangeHitChanceImpact(0.5f)}; }
    }
}
