using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assignments
{
    class largestOf3Nos
    {
        public void toCheckLargest()
        {
            int num1, num2, num3;
           
            Console.WriteLine("To find the largest of three numbers:\n");
            

            Console.WriteLine("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number "+num1+" is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number "+num3+" is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.WriteLine("The 2nd Number "+num2+" is the greatest among three \n\n");
            else
                Console.WriteLine("The 3rd Number "+num3+" is the greatest among three \n\n");
        }
    }
}
