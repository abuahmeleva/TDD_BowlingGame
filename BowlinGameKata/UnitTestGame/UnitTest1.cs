using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlinGameKata;

namespace UnitTestGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGutterGame()
        {
            Game g = new Game();

            for (int i = 0; i < 20; i++)
            {
                g.Roll(0);
            }
        }

    }
}
