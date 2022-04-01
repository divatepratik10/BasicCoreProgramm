using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Power
    {
        public static void FindPower()
        {
            Console.WriteLine("Enter 2 to the power : ");
            int pow = Convert.ToInt32(Console.ReadLine());
            ;

            for(int i = 1; i <= pow; i++)
            {
                double res = Math.Pow(2, i);
            Console.WriteLine("2 to the power {0} = {1}", pow, res);

            }

            Console.ReadLine();
        }
    }
}
