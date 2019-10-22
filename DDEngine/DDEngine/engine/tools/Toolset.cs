using System;
using DDEngine.engine.combat;

namespace DDEngine.engine.tools
{
    public class Toolset
    {
        private static Toolset toolset;

        public static Toolset GetToolset()
        {
            if(toolset == null)
            {
                toolset = new Toolset();
                SetupToolset();
            }
            return toolset;
        }

        private static void SetupToolset()
        {
            IDice d20 = new Dice(20);
            toolset.AbilityChecker = new AbilityChecker(d20);
            toolset.SupriseChecker = new SupriseChecker(toolset.AbilityChecker);
            toolset.QueueCreator = new QueueCreator();
        }

        private Toolset() { }
        public SupriseChecker SupriseChecker { get; set;}
        public AbilityChecker AbilityChecker { get; set; }
        public QueueCreator QueueCreator { get; set; }
    }
}
