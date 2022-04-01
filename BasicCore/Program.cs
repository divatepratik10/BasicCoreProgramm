﻿using System;
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
            Console.WriteLine("1 - Flip Coin\n2 - Find Leap Year\n3 - Fond Power of 2\n");
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
                default:
                    Console.WriteLine("Something Went Wrong........");
                    break;
            }

            Console.ReadLine();
        }
    }
}
