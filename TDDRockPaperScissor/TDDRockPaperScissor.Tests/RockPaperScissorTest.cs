using NUnit.Framework;
using TDDRockPaperScissorSprint;

namespace TDDRockPaperScissor.Tests
{
    public class RockPaperScissorTest
    {
        RockPaperScissor rockpaperscissor;
    
        [SetUp]
        public void Setup()
        {
            rockpaperscissor = new RockPaperScissor();
        } 
        [Test]
        public void ShouldReturnTieWhenBothPlayersArePapers()
        {
            GameOutcome result = rockpaperscissor.ChooseWinner(TeamPlayers.Paper,TeamPlayers.Paper);
            Assert.AreEqual(GameOutcome.Tie,result);
        }
        [Test]
        public void ShouldReturnPlayer1asWinnereWhenPlayer1isRockPlayer2isScissors()
        {
            GameOutcome result = rockpaperscissor.ChooseWinner(TeamPlayers.Rock,TeamPlayers.Scissors);
            Assert.AreEqual(GameOutcome.Player1,result);
        }
        [Test]
        public void ShouldReturnPlayer2asWinnereWhenPlayer1isRockPlayer2isPaper()
        {
            GameOutcome result = rockpaperscissor.ChooseWinner(TeamPlayers.Rock,TeamPlayers.Paper);
            Assert.AreEqual(GameOutcome.Player2,result);
        }
         [Test]
        public void ShouldReturnPlayer1asWinnereWhenPlayer1isScissorPlayer2isPaper()
        {
            GameOutcome result = rockpaperscissor.ChooseWinner(TeamPlayers.Scissors,TeamPlayers.Paper);
            Assert.AreEqual(GameOutcome.Player1,result);
        }
        [Test]
        public void ShouldReturnPlayer2asWinnereWhenPlayer1isScissorPlayer2isRock()
        {
            GameOutcome result = rockpaperscissor.ChooseWinner(TeamPlayers.Scissors,TeamPlayers.Rock);
            Assert.AreEqual(GameOutcome.Player2,result);
        }
        [Test]
        public void ShouldReturnPlayer2asWinnereWhenPlayer1isPaperPlayer2isRock()
        {
            GameOutcome result = rockpaperscissor.ChooseWinner(TeamPlayers.Paper,TeamPlayers.Rock);
            Assert.AreEqual(GameOutcome.Player1,result);
        }
        [Test]
        public void ShouldReturnPlayer2asWinnereWhenPlayer1isPaperPlayer2isScissor()
        {
            GameOutcome result = rockpaperscissor.ChooseWinner(TeamPlayers.Paper,TeamPlayers.Scissors);
            Assert.AreEqual(GameOutcome.Player2,result);
        }
        [Test]
        public void ShouldReturnTieIfAllRoundsAreTie()
        {
            GameOutcome result = rockpaperscissor.ChooseWinnerBasedOnStatistics(GameOutcome.Tie,GameOutcome.Tie,GameOutcome.Tie);
            Assert.AreEqual(GameOutcome.Tie,result);
        }
         [Test]
        public void ShouldReturnPlayer1AsWinnerIfPlayer1WinsAllThreeRounds()
        {
            GameOutcome result = rockpaperscissor.ChooseWinnerBasedOnStatistics(GameOutcome.Player1,GameOutcome.Player1,GameOutcome.Player1);
            Assert.AreEqual(GameOutcome.Player1,result);
        }
        [Test]
        public void ShouldReturnPlayer2AsWinnerIfPlayer2WinsAllThreeRounds()
        {
            GameOutcome result = rockpaperscissor.ChooseWinnerBasedOnStatistics(GameOutcome.Player2,GameOutcome.Player2,GameOutcome.Player2);
            Assert.AreEqual(GameOutcome.Player2,result);
        }
        [Test]
        public void ShouldReturnPlayer1AsWinnerIfPlayer1Wins2RoundsAndPlayer2Wins1Round()
        {
            GameOutcome result = rockpaperscissor.ChooseWinnerBasedOnStatistics(GameOutcome.Player1,GameOutcome.Player1,GameOutcome.Player2);
            Assert.AreEqual(GameOutcome.Player1,result);
        }
        [Test]
        public void ShouldReturnPlayer1AsWinnerIfPlayer1Wins1RoundAndOther2RoundsAreTie()
        {
            GameOutcome result = rockpaperscissor.ChooseWinnerBasedOnStatistics(GameOutcome.Player1,GameOutcome.Tie,GameOutcome.Tie);
            Assert.AreEqual(GameOutcome.Player1,result);
        }
         [Test]
        public void ShouldReturnPlayer2AsWinnerIfPlayer2Wins2RoundsAndPlayer1Wins1Round()
        {
            GameOutcome result = rockpaperscissor.ChooseWinnerBasedOnStatistics(GameOutcome.Player1,GameOutcome.Player2,GameOutcome.Player2);
            Assert.AreEqual(GameOutcome.Player2,result);
        }
        [Test]
        public void ShouldReturnPlayer1AsWinnerIfPlayer2Wins1RoundAndOther2RoundsAreTie()
        {
            GameOutcome result = rockpaperscissor.ChooseWinnerBasedOnStatistics(GameOutcome.Player2,GameOutcome.Tie,GameOutcome.Tie);
            Assert.AreEqual(GameOutcome.Player2,result);
        }

    }
}