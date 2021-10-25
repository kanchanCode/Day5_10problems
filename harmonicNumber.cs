using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assignments
{
    class harmonicNumber
    {
        public void checkHarmonic()
        {
            double sum = 0;
            Console.WriteLine("Enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            double i;
            for ( i=1; i<=num; i++)
            {
                sum += 1 / (i);
                Console.WriteLine("value of 1/"+i+" is "+(1/(i)));
               

            }
            Console.WriteLine("Harmonic value is " + sum);
        }

    }
}
