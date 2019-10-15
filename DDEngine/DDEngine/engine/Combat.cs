using DDEngine.engine.combat;
using DDEngine.engine.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.engine
{
    public class Combat
    {
        private CombatParams combatParams;

        private int round;

        private List<Player> actionQueue = new List<Player>();

        private Toolset toolset;

        public void StartNewCombat(CombatParams combatParams, Toolset toolset)
        {
            this.combatParams = combatParams;
            this.toolset = toolset;
            round = 1;
        }

        public void StartNewRound()
        {
            if (actionQueue.Count == 0)
            {
                throw new Exception("Previous round is not finished");
            }

            bool partySupriseCheckResult = false;
            if (combatParams.IsPartyStealthy)
            {
                partySupriseCheckResult = toolset.SupriseChecker.MakeSupriseCheck(combatParams.Battlefield.PartyCharacters(), combatParams.Battlefield.OppositeCharacters());
            }

            bool opponentsSupriseCheckResult = false;
            if (combatParams.AreOpponentsStealthy)
            {
                opponentsSupriseCheckResult = toolset.SupriseChecker.MakeSupriseCheck(combatParams.Battlefield.OppositeCharacters(), combatParams.Battlefield.PartyCharacters());
            }

            actionQueue = toolset.QueueCreator.MakeQueue(opponentsSupriseCheckResult ? combatParams.Battlefield.Party : null,
                partySupriseCheckResult ? combatParams.Battlefield.Opponents : null,
                toolset.AbilityChecker);

        }

        public Player GetNextPlayer()
        {
            return actionQueue.First();
        }


        public class CombatParams
        {
            private Battlefield battlefield;
            private bool isPartyStealthy;
            private bool areOpponentsStealthy;

            public CombatParams(Battlefield battlefield, bool isPartyStealthy, bool areOpponentsStealthy)
            {
                this.Battlefield = battlefield;
                this.IsPartyStealthy = isPartyStealthy;
                this.AreOpponentsStealthy = areOpponentsStealthy;
            }

            public Battlefield Battlefield { get => battlefield; set => battlefield = value; }
            public bool IsPartyStealthy { get => isPartyStealthy; set => isPartyStealthy = value; }
            public bool AreOpponentsStealthy { get => areOpponentsStealthy; set => areOpponentsStealthy = value; }
        }
    }
}
