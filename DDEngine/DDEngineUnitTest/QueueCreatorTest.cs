using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDEngine.data;
using DDEngine.engine;
using DDEngine.engine.combat;
using DDEngine.engine.tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDEngineUnitTest
{
    [TestClass]
    public class QueueCreatorTest
    {
        [TestMethod]
        public void TestQueueCreator()
        {


            AbilityChecker abilityChecker = new AbilityChecker(new StableDice());

            List<Player> party = new List<Player>
            {
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10)
            };

            List<Player> opponents = new List<Player>
            {
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10),
                CreatePlayer(10)
            };

            List<Player> queue = QueueCreator.MakeQueue(party, opponents, abilityChecker);


            Assert.AreEqual(party.Count + opponents.Count, queue.Count);
            for(int i=0; i<party.Count; i++)
            {
                Assert.AreEqual(party[i], queue[i]);
            }

            for (int i = 0; i < opponents.Count; i++)
            {
                Assert.AreEqual(opponents[i], queue[i+party.Count]);
            }

        }

        private Player CreatePlayer(int dexterity)
        {
            Character c = new Character
            {
                Abilities = new Abilities
                {
                    Dexterity = dexterity
                }
            };

            Player player = new Player
            {
                Character = c
            };
            return player;
        }

        private class StableDice : IDice
        {
            private int roll = 20;

            public int D { get => 20; set => _ = 20; }

            public int Roll()
            {
                return roll--;
            }
        }
    }
}
