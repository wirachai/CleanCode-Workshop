﻿using CleanCodeWorkshop.Tennis;
using NUnit.Framework;

namespace CleanCodeWorkshop.Test
{
    [TestFixture]
    internal class TennisGame3Test
    {
        [Test]
        public void GetScore_ShouldReturnLoveLove_WhenScoreIs0And0()
        {
            TennisGame3 game = new TennisGame3(0, 0);
            Assert.AreEqual("Love-All", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnFifteenLove_WhenScoreIs1And0()
        {
            TennisGame3 game = new TennisGame3(1, 0);
            Assert.AreEqual("Fifteen-Love", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnThirtyLove_WhenScoreIs2And0()
        {
            TennisGame3 game = new TennisGame3(2, 0);
            Assert.AreEqual("Thirty-Love", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnFortyLove_WhenScoreIs3And0()
        {
            TennisGame3 game = new TennisGame3(3, 0);
            Assert.AreEqual("Forty-Love", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnLoveFifteen_WhenScoreIs0And1()
        {
            TennisGame3 game = new TennisGame3(0, 1);
            Assert.AreEqual("Love-Fifteen", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnThirtyThirty_WhenScoreIs2And2()
        {
            TennisGame3 game = new TennisGame3(2, 2);
            Assert.AreEqual("Thirty-All", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnDeuce_WhenScoreIs3And3()
        {
            TennisGame3 game = new TennisGame3(3, 3);
            Assert.AreEqual("Deuce", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnDeuce_WhenScoreIs4And4()
        {
            TennisGame3 game = new TennisGame3(4, 4);
            Assert.AreEqual("Deuce", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnDeuce_WhenScoreIs6And6()
        {
            TennisGame3 game = new TennisGame3(6, 6);
            Assert.AreEqual("Deuce", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnWinPlayer1_WhenScoreIs4And2()
        {
            TennisGame3 game = new TennisGame3(4, 2);
            Assert.AreEqual("Win for player1", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnWinPlayer2_WhenScoreIs2And4()
        {
            TennisGame3 game = new TennisGame3(2, 4);
            Assert.AreEqual("Win for player2", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnAdvPlayer1_WhenScoreIs4And5()
        {
            TennisGame3 game = new TennisGame3(4, 5);
            Assert.AreEqual("Advantage player2", game.GetScore());
        }

        [Test]
        public void GetScore_ShouldReturnAdvPlayer2_WhenScoreIs5And4()
        {
            TennisGame3 game = new TennisGame3(5, 4);
            Assert.AreEqual("Advantage player1", game.GetScore());
        }

        [Test]
        public void RealisticTennisGame3()
        {
            TennisGame3 game = new TennisGame3(0, 0);
            Assert.AreEqual("Love-All", game.GetScore());

            string[] points = { "player1", "player1", "player2", "player2", "player1", "player1" };
            string[] expectedScores = { "Fifteen-Love", "Thirty-Love", "Thirty-Fifteen", "Thirty-All", "Forty-Thirty", "Win for player1" };
            for (int i = 0; i < expectedScores.Length; i++)
            {
                game.WonPoint(points[i]);
                Assert.AreEqual(expectedScores[i], game.GetScore());
            }
        }
    }
}