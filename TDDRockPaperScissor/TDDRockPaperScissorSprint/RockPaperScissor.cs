using System;


namespace TDDRockPaperScissorSprint
{
    public class RockPaperScissor
    {
        private int Player1WinningCount = 0;
        private int Player2WinningCount = 0;
        public GameOutcome ChooseWinner(TeamPlayers Player1, TeamPlayers Player2)
        {
            if (Player1 == TeamPlayers.Rock && Player2 == TeamPlayers.Scissors || Player1 == TeamPlayers.Scissors && Player2 == TeamPlayers.Paper || Player1 == TeamPlayers.Paper && Player2 == TeamPlayers.Rock)
            {
                return GameOutcome.Player1;
            }
            else if (Player1 == TeamPlayers.Rock && Player2 == TeamPlayers.Paper || Player1 == TeamPlayers.Scissors && Player2 == TeamPlayers.Rock || Player1 == TeamPlayers.Paper && Player2 == TeamPlayers.Scissors)
            {
                return GameOutcome.Player2;
            }
            return GameOutcome.Tie;
        }

        public GameOutcome ChooseWinnerBasedOnStatistics(GameOutcome outcome1, GameOutcome outcome2,GameOutcome outcome3)
        {
            countwinsofPlayer1(outcome1,outcome2,outcome3);
            countwinsofPlayer2(outcome1,outcome2,outcome3);
            return declarewinnerofthegame(outcome1,outcome2,outcome3);
        }
        private GameOutcome declarewinnerofthegame(GameOutcome outcome1, GameOutcome outcome2,GameOutcome outcome3)
        {
        
            GameOutcome finaloutcome = GameOutcome.Tie;
            if (Player1WinningCount > Player2WinningCount)
            {
                finaloutcome = GameOutcome.Player1;
            } else if (Player2WinningCount > Player1WinningCount)
            {
                finaloutcome = GameOutcome.Player2;
            }

            return finaloutcome;

        }

        private void countwinsofPlayer1(GameOutcome outcome1, GameOutcome outcome2,GameOutcome outcome3)
        {

            if (outcome1.Equals(GameOutcome.Player1)) 
                {
                    Player1WinningCount++;
                }
            if (outcome2.Equals(GameOutcome.Player1)) 
                {
                    Player1WinningCount++;
                }
            if (outcome3.Equals(GameOutcome.Player1)) 
                {
                    Player1WinningCount++;
                }
        }

         private void countwinsofPlayer2(GameOutcome outcome1, GameOutcome outcome2,GameOutcome outcome3)
        {

            if (outcome1.Equals(GameOutcome.Player2)) 
                {
                     Player2WinningCount++;
                }
            if (outcome2.Equals(GameOutcome.Player2)) 
                {
                     Player2WinningCount++;
                }
            if (outcome3.Equals(GameOutcome.Player2)) 
                {
                    Player2WinningCount++;
                }
        }
    }
}
