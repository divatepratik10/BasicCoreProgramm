using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class FlipCoin
    {
        public static void CountFip()
        {
            int HeadCount = 0, TailCount = 0;
            Random rr = new Random();
            Console.WriteLine("Enter how many times you want to flip the Coin ?");
            int times = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= times; i++)
            {
                double input = rr.NextDouble();

                if (input < 0.5)
                    TailCount++;
                else 
                    HeadCount++;

                Console.WriteLine(" Tail-Count {0}  Head-Count {1}", TailCount, HeadCount);
            }

            double TailPercent = (TailCount * 100) / times;
            double HeadPercent = (HeadCount * 100) / times;
                Console.WriteLine(" Tail-Count Percent : {0}  Head-Count Percent : {1}", TailPercent, HeadPercent);
            Console.ReadLine();

        }
    }
}
