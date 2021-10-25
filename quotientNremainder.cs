using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_assignments
{
    class quotientNremainder
    {
        public void division()
        {
            int dividend, divisor;
            Console.WriteLine("Enter dividend ");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter divisor ");
            divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
