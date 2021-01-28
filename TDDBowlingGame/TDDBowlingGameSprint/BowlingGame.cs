using System;
using System.Collections.Generic;

namespace TDDBowlingGameSprint
{
    public class Frame_Score
    {
        private Dictionary<int, int> dic = new Dictionary<int, int>();
        public int MaxFrame {get; set; } = 10;
        public int Frame {get; set;}
        public int Score {get; set;}

        public int MaxRolls {get; set; } = 2;
    
        public int AddFrame_Scores(int _FrameNumber, int _RollScore)
        {
        if(_FrameNumber <= MaxFrame)
        {
          Frame = _FrameNumber;
          Score += _RollScore;
        }
         return Score;
        }
               
    }

    public class BowlingGame
    {
        int FinalScore = 0;
        int rollCount = 0;
        int[] rolls = new int[20];
        Frame_Score FS = new Frame_Score();

        public int PlayGame(int _FrameNumber, int _RollScore1, int _RollScore2)
        {
            if (_FrameNumber == 1)
            {
                FinalScore = 0;
            }
           FinalScore = FS.AddFrame_Scores(_FrameNumber,(_RollScore1+_RollScore2));
           if (_FrameNumber > FS.Frame)
            {
               return FS.Score;
            }
            return FinalScore;

        }
        public int rollsScore(int knockedPins) 
        {
          return rolls[rollCount++] = knockedPins;
         }
         
    }
}
