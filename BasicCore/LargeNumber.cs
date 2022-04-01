using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class LargeNumber
    {
        public static void FindLarge_Number()
        {
            Console.WriteLine("Enter 3 numbers : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine(" {0} is the Largest number.", a);
            }
            else if(b>c)
                Console.WriteLine(" {0} is the Largest number.", b);
            else
                Console.WriteLine(" {0} is the Largest number.", c);
        }
    }
}
