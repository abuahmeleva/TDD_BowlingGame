using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlinGameKata
{
    public class Game
    {
        private int score;

        public void Roll(int pins)
        {
            score += pins;
        }

        public object Score()
        {
            return score;
        }
    }
}
