using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Swap
    {
        public static void Swapnumbers()
        {
            Console.WriteLine("Enter 2 numbers : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            Console.WriteLine("Before swap {0} {1}", a, b);
            if (a != 0 && b != 0)
            {
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("After swap {0} {1}", a, b);
            }
            else
                Console.WriteLine("one of the entered number is 0. Enter non-zero number.");
            Console.ReadLine();

        }
    }
}
