using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class QuotientnRemainder
    {
        public static void QR()
        {
            Console.WriteLine("if A/B then enter values of A & B to find Quoitient and Remainder. ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            int result = A / B;
            int result2 = A % B;

            Console.WriteLine("Quotient = {0}\nRemainder = {1}",result,result2);

            Console.ReadLine();

        }
    }
}
