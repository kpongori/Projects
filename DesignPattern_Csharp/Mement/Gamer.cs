using System;
using System.Collections.Generic;
using System.Text;

namespace Mement
{
    public class Gamer
    {
        private int money;
        private List<string> fruits = new List<string> ();
        private Random random = new Random ();
        private static string[] fruitsName = {
            "りんご",
            "ぶどう",
            "バナナ",
            "みかん",
        };

        public Gamer (int money)
        {
            this.money = money;
        }
        public int GetMoney ()
        {
            return money;
        }
        public void Bet ()
        {
            int dice = random.Next (1, 7);
            if (dice == 1)
            {
                money += 100;
                Console.WriteLine ("所持金が増えました。");
            }
            else if (dice == 2)
            {
                money /= 2;
                Console.WriteLine ("所持金が半分になりました。");
            }
            else if (dice == 6)
            {
                string f = GetFruit ();
                Console.WriteLine ("フルーツ(" + f + ")をもらいました。");
                fruits.Add (f);
            }
            else
            {
                Console.WriteLine ("何も起こりませんでした。");
            }
        }
        public Mement CreateMement ()
        {
            Mement m = new Mement (money);
            foreach (var fruit in fruits)
            {
                if (fruit.StartsWith ("おいしい"))
                {
                    m.AddFruit (fruit);
                }
            }
            return m;
        }
        public void RestoreMement (Mement mement)
        {
            this.money = mement.money;
            this.fruits = mement.GetFruits ();
        }
        public override string ToString ()
        {
            StringBuilder buffer = new StringBuilder ();
            foreach (var fruit in fruits)
            {
                buffer.Append (fruit + ", ");
            }
            return "[money = " + money + ", fruits = " + buffer.ToString () + "]";
        }
        private string GetFruit ()
        {
            string prefix = "";
            if (random.Next (2) == 1)
            {
                prefix = "おいしい";
            }
            return prefix + fruitsName[random.Next (fruitsName.Length)];
        }
    }
}