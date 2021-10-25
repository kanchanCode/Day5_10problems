using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assignments
{
    class powerOf2
    {
        public void power()
        {
            double power = 0;
            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            for (i=0;i<=n;i++)
            {
                power = Math.Pow(2, i);
                Console.WriteLine("2^"+i+" = "+power);

            }
            Console.WriteLine("Finally 2's power " + n +" is "+ power); ;
        }
    }
}
