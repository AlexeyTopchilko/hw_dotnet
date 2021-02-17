using System;

namespace HW_05_Task1
{
    class SumTo
    {
        public static void SumToNum( int number )
        {
            int result = (1 + number)*number / 2;
            Console.WriteLine($"Result of summation from 1 to {number} is {result}");
        }
    }
}