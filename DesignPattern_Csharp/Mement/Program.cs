using System;

namespace Mement
{
    class Program
    {
        static void Main (string[] args)
        {
            Gamer gamer = new Gamer (100);
            Mement mement = gamer.CreateMement ();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine ("=== " + i);
                Console.WriteLine ("現状:" + gamer);

                gamer.Bet ();

                Console.WriteLine ("所持金は" + gamer.GetMoney () + "円になりました。");
                if (gamer.GetMoney () > mement.GetMoney ())
                {
                    Console.WriteLine ("    (大分増えたので、最初の状態を保存しておこう)");
                    mement = gamer.CreateMement ();
                }
                else if (gamer.GetMoney () < mement.GetMoney () / 2)
                {
                    Console.WriteLine ("    (大分減ったので、以前の状態に復帰しよう)");
                    gamer.RestoreMement (mement);
                }
            }
        }
    }
}