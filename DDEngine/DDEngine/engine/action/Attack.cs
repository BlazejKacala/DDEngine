using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDEngine.engine.tools;

namespace DDEngine.engine.action
{
    public class Attack : IAction
    {
        private Player player;
        private Player opponent;
        private IDice dice;

        public Attack(IDice dice, Player player, Player opponent, Toolset toolset)
        {
            this.dice = dice;
            this.player = player;
            this.opponent = opponent;
        }

        public void Execute()
        {
            


        }
    }
}
