using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlinGameKata
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public object Score()
        {
            int score = 0;

            for (int i = 0; i < rolls.Length; i++)
            {
                score += rolls[i];
            }
                return score;
        }
    }
}
