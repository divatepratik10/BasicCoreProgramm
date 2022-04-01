using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class LeapYear
    {
        public static void FindLeapYR()
        {
            Console.WriteLine("Enter a Year (4 Digit) to find is it Leap year on not : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ( (year%4==0) || (year%100!=0) && (year%400==0) )
            {
                Console.WriteLine("Entered Year {0} is Leap Year.",year);
            }
            else
                Console.WriteLine("Entered Year {0} is not Leap Year.", year);
            Console.ReadLine();
        }
    }
}
