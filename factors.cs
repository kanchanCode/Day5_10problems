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
            // int [] result=new int[] { };
            //int i =1;

            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            //while (i*i<=n);




            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    // result.CopyTo(i,result);

                    Console.WriteLine("Factor of the given number is " + i);
                    
                    //  if(n/i != n)
                    // {
                    // result.CopyTo(i,result);
                    //Console.WriteLine("");
                    //  }
                }
                //i++;

            }

            // for(int j = 0; j < result; j++)
            // {
            //    Console.WriteLine("result is "+result[i]);
            //  }
            // }

        }
    }
}
