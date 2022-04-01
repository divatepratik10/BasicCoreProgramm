using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class EvenOdd
    {
        public static void Find_EvenorOdd()
        {
            Console.WriteLine("Enter a number to find it even or odd : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
                Console.WriteLine("Entered number is 0 not Even nor Odd.");
            else if (num % 2 == 0)
                Console.WriteLine("Entered number id EVEN.");
            else
                Console.WriteLine("Entered number is ODD.");

            Console.ReadLine();
        }

    }
}
