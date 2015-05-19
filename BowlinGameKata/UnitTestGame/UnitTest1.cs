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

        [TestMethod]
        public void TestGutterGame()
        {
            int rolls = 20;
            int pins = 0;

            for (int i = 0; i < rolls ; i++)
            {
                g.Roll(pins);
            }

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void TestAllGame()
        {
            Game g = new Game();

            for (int i = 0; i < 20; i++)
            {
                g.Roll(1);
            }

            Assert.AreEqual(20, g.Score());
        }

    }
}
