using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assignments
{
    class factors
    {


        public void factor()
        {

           int n;
            int isPrime;
            int i, j;

            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());

            // bcoz 1 is not prime nor composite and 2 is only even prime 

            for (i = 3; i*i <= n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = 1;

                    for (j = 2; j<= i/2; j++)
                    {

                        if (i % j == 0)
                        {
                            isPrime = 0;
                           
                            break;

                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine("Factor of the given number is " + i);
                    }
                   

                }

            }
        }
    }
}
