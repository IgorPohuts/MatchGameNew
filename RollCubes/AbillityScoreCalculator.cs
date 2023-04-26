using System;
using System.Collections.Generic;
using System.Text;

namespace RollCubes
{
    public class AbillityScoreCalculator
    {
        public int RollResult = 14;
        public double DivadeBy = 1.75;
        public int AddMount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore() 
        {
            double divided = RollResult / DivadeBy;
            int added = AddMount += (int)divided;
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else 
            {
                Score = added;
            }
        }

        
    }
}
