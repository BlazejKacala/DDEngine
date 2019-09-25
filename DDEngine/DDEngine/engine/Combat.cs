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

        private SupriseChecker supriseChecker;

        private AbilityChecker abilityChecker;

        private int round;

        private List<Player> actionQueue = new List<Player>(); 

        public void StartNewCombat(CombatParams combatParams, SupriseChecker supriseChecker, AbilityChecker abilityChecker)
        {
            this.combatParams = combatParams;
            this.supriseChecker = supriseChecker;
            this.abilityChecker = abilityChecker;
            round = 1;
        }

        public void StartNewRound()
        {
            if(actionQueue.Count == 0)
            {
                throw new Exception("Previous round is not finished");
            }

            bool partySupriseCheckResult = false;
            if(combatParams.IsPartyStealthy)
            {
                partySupriseCheckResult = supriseChecker.MakeSupriseCheck(combatParams.Battlefield.PartyCharacters(), combatParams.Battlefield.OppositeCharacters());
            }

            bool opponentsSupriseCheckResult = false;
            if (combatParams.AreOpponentsStealthy)
            {
                opponentsSupriseCheckResult = supriseChecker.MakeSupriseCheck(combatParams.Battlefield.OppositeCharacters(), combatParams.Battlefield.PartyCharacters());
            }

            actionQueue = QueueCreator.MakeQueue(opponentsSupriseCheckResult ? combatParams.Battlefield.Party : null, 
                partySupriseCheckResult ? combatParams.Battlefield.Opponents : null, 
                abilityChecker);

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
