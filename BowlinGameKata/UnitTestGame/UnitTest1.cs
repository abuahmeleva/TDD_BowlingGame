using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlinGameKata;

namespace UnitTestGame
{
    [TestClass]
    public class UnitTest1
    {
        private Game g;

        [TestInitialize]
        public void Initialize()
        {
            g = new Game();
        }

        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }

        public void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.Roll(pins);
            }
        }

        [TestMethod]
        public void TestGutterGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, g.Score());
        }


        [TestMethod]
        public void TestAllOnes()
        {
            RollMany(20, 1);

            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            RollSpare();
            RollSpare();
            g.Roll(3);
            RollMany(17, 0);

            Assert.AreEqual(16, g.Score());
        }

        [TestMethod]
        public void TestOneStrike()
        {
            g.Roll(10);//strile
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 0);

            Assert.AreEqual(24, g.Score());
        }

        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

    }
}
