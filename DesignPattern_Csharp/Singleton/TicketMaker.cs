namespace Singleton
{
    public class TicketMaker
    {
        private static TicketMaker instance = new TicketMaker ();
        private int ticket = 1000;
        private TicketMaker ()
        {

        }

        public static TicketMaker GetInstance ()
        {
            return instance;
        }

        public static int GetNextTicketNumber ()
        {
            return instance.ticket++;
        }
    }
}