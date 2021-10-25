using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assignments
{
    class oddOreven
    {
        public void checkOddNeven()
        {
            int i;
            Console.WriteLine("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
                Console.ReadLine();
            }
        }
    }
}

