using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class HarmonicNumber
    {
        public static void FindHarmonicSeries()
        {
            Console.WriteLine("Enter the number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            double s = 0.0;

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0}", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("Sum of series upto {0} is : {1}", n, s);
            Console.ReadLine();
        }
    }
}
