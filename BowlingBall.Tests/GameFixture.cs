using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    /// <summary>
    /// Test class where all the unit tests for Bowling Ball Program are written.
    /// </summary>
    [TestClass]
    public class GameFixture
    {
        private Game game;

        [TestInitialize]
        public void Setup()
        {
            //arrange - Initialize a Bowling Ball Game
            game = new Game();
        }

        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            //act
            Roll(game, 0, 20);

            //assert
            Assert.AreEqual(0, game.GetScore());
        }

        [TestMethod]
        public void Allones_game_score_should_be_twenty_test()
        {
            //act
            Roll(game,1, 20);

            //assert
            Assert.AreEqual(20, game.GetScore());
        }

        [TestMethod]
        public void Spare_followed_by_two_game_score_should_be_fourteen_test()
        {
            //act
            game.Roll(5);
            game.Roll(5);
            game.Roll(2);
            Roll(game,0, 17);

            //assert
            Assert.AreEqual(14, game.GetScore());
        }

        [TestMethod]
        public void Strike_followed_by_five_then_two_game_score_should_be_twenty_four_test()
        {
            //act
            game.Roll(10);
            game.Roll(5);
            game.Roll(2);
            Roll(game,0, 17);

            //assert
            Assert.AreEqual(24, game.GetScore());
        }

        [TestMethod]
        public void AllStrike_game_score_should_be_three_hundred_test()
        {
            //act
            Roll(game,10, 12);

            //assert
            Assert.AreEqual(300, game.GetScore());
        }

        private void Roll(Game game, int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
