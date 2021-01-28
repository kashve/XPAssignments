using NUnit.Framework;
using TDDBowlingGameSprint;
using System;

namespace TDDBowlingGame.Tests
{
    public class BowlingGameTest
    {
        BowlingGame game;
        Frame_Score frame;

        [SetUp]
        public void Setup()
        {
            game = new BowlingGame();
            frame = new Frame_Score();
        }

        //TestCase 1 AC 1

        [Test]
        public void ShouldRetrunFrameCount_PassesWithMaxof10FramesAsCount_BowlingGame()
        {

            Assert.AreEqual(10, frame.MaxFrame);
        }

        //TestCase 2 AC 2

        [Test]
        public void ShouldReturnCountofMaxof2RollsInaFrame_WithPinsCountOf10_BowlingGame()
        {
          Assert.AreEqual(2, game.rollsScore(2));
        }

        // TestCase 3 AC 3
        [Test]
        public void ShouldReturnFrame1Score_SumOfMax2RollScores_BowlingGame()
        {
            

            Assert.That(game.PlayGame(1,1,4), Is.EqualTo(5));
        }

         // TestCase 4 AC 3
        [Test]
         public void ShouldReturnFrame2Score_SumOfPreviousFrameandCurrentFrameScores_BowlingGame()
        {
            int result = 0;
            result = game.PlayGame(1,1,4);
            result = game.PlayGame(2,3,5);
            result = game.PlayGame(3,5,3);
            Assert.AreEqual(21,result);
        }

        // TestCase 5 AC 3
        [Test]
        public void ShouldReturnTotalRollScoresOfAll10FramesTillTheLastFrame_BowlingGame() 
         {
             int result = 0;
            result = game.PlayGame(1,1,4);
            result = game.PlayGame(2,3,5);
            result = game.PlayGame(3,5,3);
            result = game.PlayGame(4,2,0);
            result = game.PlayGame(5,2,6);
            result = game.PlayGame(6,0,4);
            result = game.PlayGame(7,0,0);
            result = game.PlayGame(8,4,5);
            result = game.PlayGame(9,5,5);
            result = game.PlayGame(10,8,0);
    
            Assert.AreEqual(62,result);     
        
         }
         // TestCase 6 AC 4
         [Test]
         public void ShouldReturnTotalRollScoreOfTheLastFrame_BowlingGame() 
         {
             int result = 0;
            result = game.PlayGame(1,1,4);
            result = game.PlayGame(2,3,5);
            result = game.PlayGame(3,5,3);
            result = game.PlayGame(4,2,0);
            result = game.PlayGame(5,2,6);
            result = game.PlayGame(6,0,4);
            result = game.PlayGame(7,0,0);
            result = game.PlayGame(8,4,5);
            result = game.PlayGame(9,5,5);
            result = game.PlayGame(10,8,0);
    
            Assert.AreEqual(62,result);     
        
         }
         // TestCase 7 AC 5
        [Test]
         public void ShouldEndTheBowlingGame_WhenFrameCountIsMoreThan10_BowlingGame() 
         {
             int result = 0;
            result = game.PlayGame(1,1,4);
            result = game.PlayGame(2,3,5);
            result = game.PlayGame(3,5,3);
            result = game.PlayGame(4,2,0);
            result = game.PlayGame(5,2,6);
            result = game.PlayGame(6,0,4);
            result = game.PlayGame(7,0,0);
            result = game.PlayGame(8,4,5);
            result = game.PlayGame(9,5,5);
            result = game.PlayGame(10,8,0);
            result = game.PlayGame(11,10,10);
            Assert.AreEqual(62,result);     
        
         }
      [OneTimeTearDown]
        public void TearDown()
        {
            game = null;
            frame = null;

        }
       
    }
}