using System;

namespace Day5_assignments
{
    class Program
    {
        static void Main(string[] args)

        {
            int n;
            Console.WriteLine("1. Percentage of head and tail a flipped coin");
            Console.WriteLine("2. Check whether given year is leap or not ");
            Console.WriteLine("3. Run till power of 2 becomes equal to input");
            Console.WriteLine("4. Harmonic number");
            Console.WriteLine("5. Calculate prime factors");
            Console.WriteLine("6. Cmpute Quotient and Remainder");
            Console.WriteLine("7. Swapping two numbers");
            Console.WriteLine("8. Check even and odd");
            Console.WriteLine("9. Check Whether an Alphabet is Vowel or Consonant");
            Console.WriteLine("10.Check max of 3 Nos");
            Console.WriteLine("Enter your choice from above menu");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    if (n == 1)
                    {
                        coinFlip obj1 = new coinFlip();
                        obj1.check();
                    }
                    break;
                case 2:
                    leapYear obj2 = new leapYear();
                    obj2.yearCheck();

                    break;
                case 3:
                    powerOf2 obj3 = new powerOf2();
                    obj3.power();
                    break;
                case 4:
                    harmonicNumber obj4 = new harmonicNumber();
                    obj4.checkHarmonic(); 
                    break;
                case 5:
                    factors obj5 = new factors();
                    obj5.factor();

                    break;
                case 6:
                    quotientNremainder obj6 = new quotientNremainder();
                    obj6.division();

                    break;
                case 7:
                    swapTwoNo obj7 = new swapTwoNo();
                    obj7.swapping();

                    break;
                case 8:
                    oddOreven obj8 = new oddOreven();
                    obj8.checkOddNeven();

                    break;
                case 9:
                    vowelOrConsonant obj9 = new vowelOrConsonant();
                    obj9.checkVowelNconsonant();
                    break;
                case 10:
                    largestOf3Nos obj10 = new largestOf3Nos();
                    obj10.toCheckLargest();
                    break;
                default:
                    break;

                    

            }
        }
    }
}
