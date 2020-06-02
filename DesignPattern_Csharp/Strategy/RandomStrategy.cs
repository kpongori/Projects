using System;
namespace Strategy
{
    public class RandomStrategy : IStrategy
    {
        private Random random;
        private bool won = false;
        private Hand prevHand;

        public WinningStrategy (int seed)
        {
            random = new Random (seed);
        }
        public Hand NextHand ()
        {
            prevHand = Hand.GetHand (random.Next (0, 3));
            return prevHand;
        }
        public void Study (bool win)
        {
            won = win;
        }
    }
}