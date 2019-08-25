using System;
using DDEngine.engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDEngineUnitTest
{
    [TestClass]
    public class DiceTest
    {
        [TestMethod]
        public void TestDice()
        {
            IDice D20 = new Dice(20);

            for(int i=0;i<1000;i++)
            {
                int result = D20.Roll();
                Assert.IsTrue(result > 0 && result <=20);
            }
        }
    }
}
