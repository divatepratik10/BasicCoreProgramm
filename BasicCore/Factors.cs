using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Factors
    {
        public static void FindFactors()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors of {0} are : ");
            for(int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
