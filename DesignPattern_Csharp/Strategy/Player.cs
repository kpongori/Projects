namespace Strategy
{
    public class Player
    {
        private string name;
        private IStrategy strategy;
        private int winCount;
        private int loseCount;
        private int gameCount;

        public Player (string name, IStrategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        public Hand NextHand ()
        {
            return strategy.NextHand ();
        }
        public void Win ()
        {
            strategy.Study (true);
            winCount++;
            gameCount++;
        }
        public void Lose ()
        {
            strategy.Study (false);
            loseCount++;
            gameCount++;
        }
        public void Even ()
        {
            gameCount++;
        }
        public override string ToString ()
        {
            return "[" + name + ":" + gameCount + " games, " +
                winCount + " win, " + loseCount + " lose" + "]";
        }
    }
}