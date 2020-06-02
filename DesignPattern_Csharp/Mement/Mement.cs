using System.Collections.Generic;

namespace Mement
{
    public class Mement
    {
        internal int money;
        internal List<string> fruits;

        public int GetMoney ()
        {
            return money;
        }
        internal Mement (int money)
        {
            this.money = money;
            this.fruits = new List<string> ();
        }
        internal void AddFruit (string fruit)
        {
            fruits.Add (fruit);
        }
        internal List<string> GetFruits ()
        {
            return fruits;
        }
    }
}