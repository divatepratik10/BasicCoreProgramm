using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programms.");
            Console.WriteLine("Choose what you want to do ?");
            Console.WriteLine("1 - Flip Coin\n2 - Find Leap Year\n3 - Fond Power of 2\n4 - Find Harmonic Series" +
                "\n5 - Find Factors\n6 - Find Quotient & Remainder\n7 - Swap 2 Numbers\n8 - Find number is even or odd" +
                "\n9 - Alphabate is Vowel or Consonent\n10 - Largest number");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    FlipCoin.CountFip();
                    break;
                case 2:
                    LeapYear.FindLeapYR();
                    break;
                case 3:
                    Power.FindPower();
                    break;
                case 4:
                    HarmonicNumber.FindHarmonicSeries();
                    break;
                case 5:
                    Factors.FindFactors();
                    break;
                case 6:
                    QuotientnRemainder.QR();
                    break;
                case 7:
                    Swap.Swapnumbers();
                    break;
                case 8:
                    EvenOdd.Find_EvenorOdd();
                    break;
                case 9:
                    VowelorConsonent.Vowel_Consonent();
                    break;
                case 10:
                    LargeNumber.FindLarge_Number();
                    break;
                default:
                    Console.WriteLine("Something Went Wrong........");
                    break;
            }

            Console.ReadLine();
        }
    }
}
