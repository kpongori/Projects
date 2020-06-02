namespace Strategy
{
    public class Hand
    {
        public static int HANDVALUE_GUU = 0;
        public static int HANDVALUE_CHO = 1;
        public static int HANDVALUE_PAA = 2;
        public static Hand[] hand = {
            new Hand (HANDVALUE_GUU),
            new Hand (HANDVALUE_CHO),
            new Hand (HANDVALUE_PAA)
        };
        private static string[] name = {
            "グー",
            "チョキ",
            "パー"
        };
        private int handValue;

        private Hand (int handValue)
        {
            this.handValue = handValue;
        }
        public static Hand GetHand (int handValue)
        {
            return hand[handValue];
        }
        public bool IsStrongerThan (Hand h)
        {
            return Fight (h) == 1;
        }
        public bool IsWeakerThan (Hand h)
        {
            return Fight (h) == -1;
        }
        private int Fight (Hand h)
        {
            if (this == h)
            {
                return 0;
            }
            else if ((this.handValue + 1) % 3 == h.handValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public string ToString ()
        {
            return name[handValue];
        }
    }
}