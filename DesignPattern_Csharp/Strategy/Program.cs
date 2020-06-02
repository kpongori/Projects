using System;

namespace Strategy
{
    class Program
    {
        static void Main (string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine ("Usage: c# Main randomSeed1 randomSeed2");
                Console.WriteLine ("Example: c# Main 314 15");
                return;
            }
            int seed1 = int.Parse (args[0]);
            int seed2 = int.Parse (args[1]);
            Player player1 = new Player ("Taro", new WinningStrategy (seed1));
            Player player2 = new Player ("Hana", new ProbStrategy (seed2));
            for (int i = 0; i < 10000; i++)
            {
                Hand nextHand1 = player1.NextHand ();
                Hand nextHand2 = player2.NextHand ();
                if (nextHand1.IsStrongerThan (nextHand2))
                {
                    player1.Win ();
                    player2.Lose ();
                    Console.WriteLine ("Winner:" + player1.ToString ());
                }
                else if (nextHand2.IsStrongerThan (nextHand1))
                {
                    player1.Lose ();
                    player2.Win ();
                    Console.WriteLine ("Winner:" + player2.ToString ());
                }
                else
                {
                    player1.Even ();
                    player2.Even ();
                    Console.WriteLine ("Even...");
                }

                Console.WriteLine ("Total Result:");
                Console.WriteLine (player1.ToString ());
                Console.WriteLine (player2.ToString ());
            }
        }

    }
}