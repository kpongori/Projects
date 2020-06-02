using System.Collections.Generic;

namespace Flyweight
{
    public class BigCharFactory
    {
        private Dictionary<string, BigChar> map = new Dictionary<string, BigChar> ();
        private static BigCharFactory instance = new BigCharFactory ();

        private BigCharFactory ()
        {

        }
        public static BigCharFactory GetInstance ()
        {
            return instance;
        }
        public BigChar GetBigChar (char charName)
        {
            BigChar bc = null;
            bool exist = map.ContainsKey ("" + charName);
            if (!exist)
            {
                bc = new BigChar (charName);
                map.Add ("" + charName, bc);
                return bc;
            }
            return map["" + charName];
        }
    }
}