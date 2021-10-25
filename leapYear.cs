using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assignments
{
    class leapYear
    {
        public void yearCheck()
        {
            
            Console.WriteLine("Enter year ");
            int y = Convert.ToInt32(Console.ReadLine());
           if (((y%4==0)&&(y%400==0))||(y%100!=0))
            {
                Console.WriteLine("Its a leap year");
            }
            else
            {
               
                Console.WriteLine("Not a Leap year");
            }
        }
    }
}
