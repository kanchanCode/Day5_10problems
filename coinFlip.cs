using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assignments
{
    class coinFlip
    {
        public void check()
        {

            const int HEAD = 1;
            double headCount = 0;
            double tailCount = 0;
            
            double Hpercentage;
            double Tpercentage;
            
            Console.WriteLine("Enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<num;i++)
            {
                Random random = new Random();
                int outcome = random.Next(1, 3);
                

                if (outcome == HEAD)
                {
                    Console.WriteLine("Head");
                    headCount += 1;
                }
                else 
                {
                    Console.WriteLine("Tail");
                    tailCount += 1;

                }
               
            }
            Console.WriteLine("total number of heads "+headCount);
            Console.WriteLine("total number of tails "+tailCount);
            Hpercentage = ((headCount/num)*100);
            Tpercentage = ((tailCount /num) * 100);
            Console.WriteLine("total head percentage "+Hpercentage+"%");
            Console.WriteLine("total tail percentage "+Tpercentage+"%");

        }

    }
}
