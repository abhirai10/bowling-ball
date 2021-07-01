using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    /// <summary>
    /// A Bowling Ball Game.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Field to store no. of pins down for every roll.
        /// </summary>
        private int[] rolls = new int[21];

        /// <summary>
        /// Current roll
        /// </summary>
        private int roll = 0;

        /// <summary>
        /// Store the number of pins down for the current roll.
        /// </summary>
        /// <param name="pins">Number of Pins down.</param>
        public void Roll(int pins)
        {
            rolls[roll++] = pins;
        }

        /// <summary>
        /// Get total Score of the Bowling Ball Game.
        /// </summary>
        /// <returns>Total Score of the game.</returns>
        public int GetScore()
        {
            int score = 0;
            int rollIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(rollIndex))
                {
                    score += 10 + rolls[rollIndex + 1] + rolls[rollIndex + 2];
                    rollIndex++;
                }
                else if (IsSpare(rollIndex))
                {
                    score += 10 + rolls[rollIndex + 2];
                    rollIndex += 2;
                }
                else
                {
                    score += rolls[rollIndex] + rolls[rollIndex + 1];
                    rollIndex += 2;
                }
            }

            return score;
        }

        /// <summary>
        /// Check if the roll was a Strike.
        /// </summary>
        /// <param name="rollIndex">Index of Roll.</param>
        /// <returns>Returns true if Strike else false.</returns>
        private bool IsStrike(int rollIndex)
        {
            return rolls[rollIndex] == 10;
        }

        /// <summary>
        /// Check if the roll was a Spare.
        /// </summary>
        /// <param name="rollIndex">Index of Roll.</param>
        /// <returns>Returns true if Spare else false.</returns>
        private bool IsSpare(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
        }
    }
}
