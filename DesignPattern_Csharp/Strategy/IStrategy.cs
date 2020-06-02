namespace Strategy
{
    public interface IStrategy
    {
        Hand NextHand ();
        void Study (bool win);
    }
}