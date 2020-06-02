using System;

namespace Strategy
{
    public class ProbStrategy : IStrategy
    {
        private Random random;
        private int prevHandValue = 0;
        private int currentHandValue = 0;
        private int[][] history = {
            new int[] { 1, 1, 1, },
            new int[] { 1, 1, 1, },
            new int[] { 1, 1, 1, },
        };

        public ProbStrategy (int seed)
        {
            random = new Random (seed);
        }
        public Hand NextHand ()
        {
            int bet = random.Next (0, GetSum (currentHandValue));
            int handValue = 0;
            if (bet < history[currentHandValue][0])
            {
                handValue = 0;
            }
            else if (bet < history[currentHandValue][0] + history[currentHandValue][1])
            {
                handValue = 1;
            }
            else
            {
                handValue = 2;
            }
            prevHandValue = currentHandValue;
            currentHandValue = handValue;
            return Hand.GetHand (handValue);
        }
        private int GetSum (int hv)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += history[hv][i];
            }
            return sum;
        }
        public void Study (bool win)
        {
            if (win)
            {
                history[prevHandValue][currentHandValue]++;
            }
            else
            {
                history[prevHandValue][(currentHandValue + 1) % 3]++;
                history[prevHandValue][(currentHandValue + 2) % 3]++;
            }
        }
    }
}