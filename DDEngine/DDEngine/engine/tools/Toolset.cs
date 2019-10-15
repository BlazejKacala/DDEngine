using System;
using DDEngine.engine.combat;

namespace DDEngine.engine.tools
{
    public class Toolset
    {
        public static Toolset getNewToolset
        {

        }

        private Toolset() { }
        public SupriseChecker SupriseChecker { get; set;}
        public AbilityChecker AbilityChecker { get; set; }
    }
}
